﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace UserControls
{
    public partial class UC_Purchases : UserControl
    {
        DBHandler db;
        public UC_Purchases()
        {
            InitializeComponent();
        }

        public void Start()
        {
            if (db == null)
            {
                db = new DBHandler();
                dgv_purchases.DoubleBuffered(true);

                DataTable categories_data_table = db.ExecuteSQL("SELECT * FROM categories");
                combo_category_name.DisplayMember = "category";
                combo_category_name.ValueMember = "id";
                combo_category_name.DataSource = categories_data_table;

                combo_category_name.SelectedIndexChanged += combo_category_name_SelectedIndexChanged;
                combo_category_name_SelectedIndexChanged(combo_category_name, EventArgs.Empty);

                combo_unit_name.SelectedIndexChanged += combo_unit_name_SelectedIndexChanged;


                DataTable years = db.ExecuteSQL("SELECT DISTINCT  year FROM purchases_monthes");
                combo_years.DataSource = years.ColumnToArray(0);
            }
        }

        private void combo_category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable products_names_table = db.ExecuteSQL(string.Format("SELECT product_name_id, product_name FROM products_names WHERE category_id = {0} ORDER BY product_name",
                combo_category_name.SelectedValue.ToString()));

            lbl_category_id.Text = combo_category_name.SelectedValue.ToString();

            combo_product_name.DisplayMember = "product_name";
            combo_product_name.ValueMember = "product_name_id";
            combo_product_name.DataSource = products_names_table;
        }

        private void combo_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_product_name_id.Text = combo_product_name.SelectedValue.ToString();
            GetUintsForProducts();
        }

        private void GetUintsForProducts()
        {
            string base_units_query = string.Format(@"
SELECT units.id AS unit_id, 
       units.unit AS unit_name
  FROM products_units_info
       JOIN units ON products_units_info.base_unit_id = units.id 
WHERE products_units_info.product_name_id = {0}
ORDER BY unit_name ;"
                , combo_product_name.SelectedValue.ToString());

            string sub_units_query = string.Format(@"
SELECT units.id AS unit_id, 
       units.unit AS unit_name
  FROM products_units_info
       JOIN units ON products_units_info.sub_unit_id = units.id 
WHERE products_units_info.product_name_id = {0}
  AND products_units_info.sub_unit_is_purchaseable = 'نعم'
ORDER BY unit_name ;"
                , combo_product_name.SelectedValue.ToString());

            DataTable all_product_untis = new DataTable();
            all_product_untis = db.ExecuteSQL(base_units_query);
            all_product_untis.Merge(db.ExecuteSQL(sub_units_query));

            combo_unit_name.DataSource = all_product_untis;
            combo_unit_name.DisplayMember = "unit_name";
            combo_unit_name.ValueMember = "unit_id";

        }

        private void combo_unit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_unit_id.Text = combo_unit_name.SelectedValue.ToString();
        }

        private void calcTotal(object sender, EventArgs e)
        {
            double price, quantity;
            double.TryParse(text_price.Text, out price);
            double.TryParse(text_quantity.Text, out quantity);

            lbl_total.Text = (price * quantity).ToString();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            if (lbl_total.Text == "0")
            {
                var notification = new System.Windows.Forms.NotifyIcon()
                {
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Shield,
                    BalloonTipTitle = "خطأ أثناء الحفظ",
                    BalloonTipText = "الكمية أو السعر فارغ",
                };
                notification.ShowBalloonTip(1000);
                return;
            }


            DataTable years = db.ExecuteSQL("SELECT DISTINCT  year FROM purchases_monthes");
            combo_years.DataSource = years.ColumnToArray(0);

            new SettingPrices().ShowDialog(
                combo_product_name.SelectedValue.ToString(),
                combo_unit_name.SelectedValue.ToString(),
                text_price.Text);
            DateTime date = dateTimePicker1.Value;

            string purchased_query = string.Format(@"INSERT INTO purchases VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' )",
                combo_category_name.SelectedValue.ToString(),
                combo_product_name.SelectedValue.ToString(),
                combo_unit_name.SelectedValue.ToString(),
                text_price.Text,
                text_quantity.Text,
                lbl_total.Text,
                date.ToString("yyyy/MM/dd"));
            db.ExecuteSQL(purchased_query);


            string sql = string.Format(@"INSERT INTO purchases_monthes
                            SELECT '{0}', '{1}' 
                            WHERE NOT EXISTS ( SELECT 1 FROM purchases_monthes 
                            WHERE year = '{0}' AND monthes = '{1}');",
                                                                    date.Date.ToString("yyyy"),
                                                                    date.Date.ToString("MM"));

            db.ExecuteSQL(sql);

            combo_years_SelectedIndexChanged(combo_years, EventArgs.Empty);
        }

        private void combo_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT monthes FROM purchases_monthes WHERE year = ";
            sql += combo_years.Text;
            sql += " ORDER BY monthes DESC";
            DataTable monthes = db.ExecuteSQL(sql);
            combo_monthes.DataSource = monthes.ColumnToArray(0);
        }

        private void combo_monthes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string purchases_query = string.Format(@"
                                                SELECT categories.category,
                                                        products_names.product_name,
                                                        units.unit,
                                                        purchases.unit_price,
                                                        purchases.amount,
                                                        purchases.total,
                                                        purchases.purchase_date
                                                    FROM purchases
                                                        JOIN
                                                        categories ON purchases.category_id = categories.id
                                                        JOIN
                                                        products_names ON purchases.product_name_id = products_names.product_name_id
                                                        JOIN
                                                        units ON purchases.unit_id = units.id
                                                        WHERE purchases.purchase_date LIKE '{0}/{1}/__'

                                                ", combo_years.Text, combo_monthes.Text);

            DataTable purchases_table = db.ExecuteSQL(purchases_query);
            dgv_purchases.DataSource = purchases_table;
        }

        private void dgv_purchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            combo_category_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[0].Value.ToString();
            combo_product_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[1].Value.ToString();
            combo_unit_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[2].Value.ToString();

            text_price.Text = dgv_purchases.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_quantity.Text = dgv_purchases.Rows[e.RowIndex].Cells[4].Value.ToString();

            SettingPrices setting_prices = new SettingPrices();
            setting_prices.ShowDialog(lbl_product_name_id.Text, lbl_unit_id.Text, text_price.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.ToString("yyyy");
            string month = dateTimePicker1.Value.ToString("MM");
            if (combo_years.Items.Contains(year))
            {
                if (combo_monthes.Items.Contains(month))
                {
                    combo_years.Text = year;
                    combo_monthes.Text = month;
                }
            }
        }

        private void ViewMonthTable(string year, string month)
        {

            string purchases_query = string.Format(@"
                                                SELECT categories.category,
                                                        products_names.product_name,
                                                        units.unit,
                                                        purchases.unit_price,
                                                        purchases.amount,
                                                        purchases.total,
                                                        purchases.purchase_date
                                                    FROM purchases
                                                        JOIN
                                                        categories ON purchases.category_id = categories.id
                                                        JOIN
                                                        products_names ON purchases.product_name_id = products_names.product_name_id
                                                        JOIN
                                                        units ON purchases.unit_id = units.id
                                                        WHERE purchases.purchase_date LIKE '{0}/{1}/__'

                                                ", year, month);
            DataTable purchases_table = db.ExecuteSQL(purchases_query);
            dgv_purchases.DataSource = purchases_table;
        }

        private void TextBoxSelectAll(object sender)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
        }

        private void text_quantity_Enter(object sender, EventArgs e)
        {
            TextBoxSelectAll(sender);
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSelectAll(sender);
        }

        private void lbl_product_name_id_Click(object sender, EventArgs e)
        {
            GetUintsForProducts();
        }
    }
}
