using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataAccessLayer;
using Models;

namespace UserControls
{
    public partial class UC_Sales : UserControl
    {

        //private DataTable AllCategoryProducts { get; set; }
        //private string category;
        //private int category_id;

        DBHandler db { get; set; }
        private Product current_product = new Product();
        private Timer timer = new Timer();
        private string next_process_id;
        private int last_serial;
        private string work_day;


        public UC_Sales()
        {
            InitializeComponent();
            foreach (DataGridViewColumn col in dgv_sales.Columns)
                col.ContextMenuStrip = dgvDailySalesProperties;
        }

        private void UC_DailySales_Load(object sender, EventArgs e)
        {

        }
        public void Start()
        {
            dgv_sales.DoubleBuffered(true);

            lbl_work_day.Text = date_picker_work_day.Value.ToString("ddd") + " " + date_picker_work_day.Value.ToString("yyyy/M/d");
            work_day = date_picker_work_day.Value.ToString("yyyyMMdd");
            if (db == null)
            {
                lbl_day_total.Text = "0";
                timer.Interval = 10;
                timer.Tick += timer_Tick;
                timer.Start();
                db = new DBHandler();

                date_picker_work_day.Value = DateTime.Now.Date;

                viewWorkDaySales();
            }
            dgv_sales.CellValueChanged += dgv_sales_CellValueChanged;

            GetCategories();
            combo_category_name.SelectedValueChanged += combo_category_name_SelectedValueChanged;
            combo_category_name_SelectedValueChanged(combo_category_name, EventArgs.Empty);
        }

        private void GetCategories()
        {
            DataTable categories_table = db.ExecuteSQL("SELECT id, category FROM categories");
            combo_category_name.DataSource = categories_table;
            combo_category_name.DisplayMember = "category";
            combo_category_name.ValueMember = "id";
        }
        private void combo_category_name_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_category_id.Text = combo_category_name.SelectedValue.ToString();
            string sql = @"SELECT products.product_id,
                            products_names.product_name,
                            units.unit AS unit_name,
                            units.id As unit_id,
                            products.amount,
                            products.selling_price
                            FROM products
                                   INNER JOIN
                                   products_names ON products.product_name_id = products_names.product_name_id
                                   INNER JOIN
                                   units ON products.unit_id = units.id
                            WHERE products.category_id = ";
            sql += combo_category_name.SelectedValue.ToString();
            sql += " ORDER BY products_names.product_name";

            combo_product_name.DataSource = db.ExecuteSQL(sql);
            combo_product_name.DisplayMember = "product_name";
            combo_product_name.ValueMember = "product_id";
            combo_product_name.SelectedValueChanged += combo_product_name_ValueMemberChanged;
            combo_product_name_ValueMemberChanged(combo_product_name, EventArgs.Empty);
        }


        private void combo_product_name_ValueMemberChanged(object sender, EventArgs e)
        {

            if (combo_product_name.SelectedValue != null)
            {
                lbl_product_id.Text = combo_product_name.SelectedValue.ToString();
                this.current_product.ProductID = int.Parse(combo_product_name.SelectedValue.ToString());
                Console.WriteLine(this.current_product.ProductID);
                lbl_price.Text = this.current_product.selling_price.ToString();
                lbl_unit.Text = this.current_product.unit_name.ToString();

                upateTotal();
                text_quantity.Focus();
                text_quantity.SelectAll();
            }
        }

        private void viewWorkDaySales()
        {
            string sql = string.Format(
                       @"SELECT sales.process_id, categories.category AS category_name, products.product_id, products_names.product_name, units.unit AS unit_name,
                            sales.amount, sales.price, sales.total, sales.time_of_sale
                            FROM sales
                            JOIN categories ON sales.category_id = categories.id
                            JOIN products ON sales.product_id = products.product_id
                            JOIN products_names ON products.product_name_id = products_names.product_name_id
                            JOIN units ON sales.unit_id = units.id
                            WHERE sales.process_id LIKE '{0}____' ORDER BY process_id", work_day);
            DataTable sates_table = db.ExecuteSQL(sql);
            dgv_sales.DataSource = sates_table;
            next_process_id = generateProcessID(sates_table);
        }
        private string generateProcessID(DataTable t)
        {
            string last_process_id;
            if (t.Rows.Count == 0)
            {
                last_serial = 1;
                return work_day + "000" + last_serial.ToString();
            }
            else
            {
                last_process_id = t.Rows[t.Rows.Count - 1][0].ToString();
                last_serial = int.Parse(last_process_id.Substring(8));
                double day_total = 0;

                foreach (DataRow dr in t.Rows)
                {
                    day_total += double.Parse(dr["total"].ToString());
                }
                dgv_sales.DataSource = t;
                lbl_day_total.Text = day_total.ToString();
                last_serial++;
                return work_day.PadRight(12 - last_serial.ToString().Length, '0') + (last_serial).ToString();

            }
        }

        private void updateNextProcessID()
        {
            last_serial++;
            next_process_id = work_day.PadRight(12 - last_serial.ToString().Length, '0') + (last_serial).ToString();
        }


        private void upateTotal()
        {
            double price = 0, quantity = 0;
            double.TryParse(lbl_price.Text, out price);
            double.TryParse(text_quantity.Text, out quantity);
            lbl_total.Text = (price * quantity).ToString();
        }





        private void text_quantity_TextChanged(object sender, EventArgs e)
        {
            upateTotal();
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            text_quantity.SelectAll();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double x;
            if (text_quantity.Text == "0" || !double.TryParse(text_quantity.Text, out x))
                return;
            List<string> data = new List<string>();

            data.Add(next_process_id);
            data.Add(this.current_product.ProductID.ToString());
            data.Add(text_quantity.Text);
            data.Add(this.current_product.selling_price.ToString());
            data.Add(lbl_total.Text);
            data.Add(DateTime.Now.ToString("HH:mm:ss"));
            data.Add(DateTime.Now.Date.ToShortDateString());
            data.Add(this.current_product.category_id.ToString());
            data.Add(current_product.unit_id.ToString());

            db.insertDataIntoTable(data, "sales");

            string sql = @"SELECT sales.process_id, categories.category, products.product_id, products_names.product_name, units.unit, 
                            sales.amount, sales.price, sales.total, sales.time_of_sale
                            FROM sales
                            JOIN categories ON sales.category_id = categories.id
                            JOIN products ON sales.product_id = products.product_id
                            JOIN products_names ON products.product_name_id = products_names.product_name_id
                            JOIN units ON sales.unit_id = units.id
                            WHERE sales.process_id = ";
            sql += next_process_id;

            DataTable sales_data_table = (DataTable)dgv_sales.DataSource;
            sales_data_table.Rows.Add(db.ExecuteSQL(sql).Rows[0].ItemArray);
            text_quantity.Text = "0";
            text_quantity.Focus();
            text_quantity.SelectAll();
            updateNextProcessID();

            double day_total = double.Parse(lbl_day_total.Text.ToString());
            day_total += double.Parse(dgv_sales.Rows[dgv_sales.Rows.Count - 1].Cells[7].Value.ToString());
            lbl_day_total.Text = day_total.ToString();
            dgv_sales.FirstDisplayedScrollingRowIndex = dgv_sales.Rows.Count - 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void text_quantity_MouseClick_1(object sender, MouseEventArgs e)
        {
            text_quantity.SelectAll();
        }

        private void text_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_save.PerformClick();
        }


        private int current_row_index;

        private void dgv_sales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            current_row_index = e.RowIndex;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = dgv_sales.SelectedRows;
            if (selected.Count > 0)
            {
                for (int i = 0; i < selected.Count; i++)
                {
                    db.DeleteData("sales", selected[i].Cells[0].Value.ToString());
                    dgv_sales.Rows.Remove(selected[i]);
                }
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_sales.ClearSelection();
                dgv_sales.Rows[current_row_index].Selected = true;

                db.DeleteData("sales", dgv_sales.Rows[current_row_index].Cells[0].Value.ToString());
                dgv_sales.Rows.RemoveAt(current_row_index);
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dgv_sales.Rows.Count == 0)
            {
                last_serial = 0;
            }
        }

        private void text_quantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.PerformClick();
            }
        }

        public void dgv_sales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                double day_total = double.Parse(lbl_day_total.Text);
                day_total = day_total - double.Parse(dgv_sales.Rows[e.RowIndex].Cells[7].Value.ToString());
                lbl_day_total.Text = day_total.ToString();
                double amount, price, total;
                string process_id;
                amount = double.Parse(dgv_sales.Rows[e.RowIndex].Cells[5].Value.ToString());
                price = double.Parse(dgv_sales.Rows[e.RowIndex].Cells[6].Value.ToString());
                total = amount * price;
                process_id = dgv_sales.Rows[e.RowIndex].Cells[0].Value.ToString();
                db.UpdateSalesTable(amount, price, total, process_id);
                dgv_sales.Rows[e.RowIndex].Cells[7].Value = total;
                day_total += total;
                lbl_day_total.Text = day_total.ToString();
            }

        }

        private void workDay_ValueChanged(object sender, EventArgs e)
        {
            lbl_work_day.Text = date_picker_work_day.Value.ToString("ddd") + " " + date_picker_work_day.Value.ToString("yyyy/M/d");
            this.work_day = date_picker_work_day.Value.ToString("yyyyMMdd");
            viewWorkDaySales();
        }

        private void gbtn_view_products_Click(object sender, EventArgs e)
        {
            FormAllCategoryProducts all = new FormAllCategoryProducts();
            all.SelectedProductChanged += all_SelectedProductChanged;

            all.ProductSaved += all_ProductSaved;

            all.ShowDialog(combo_category_name.DataSource);

        }

        private void all_ProductSaved(object sender, SelectedProductChangedArgs e)
        {
            combo_category_name.Text = e.CategoryName;
            combo_product_name.SelectedValue = e.ProductName;
            text_quantity.Text = e.Amount;
            btn_save.PerformClick();
        }

        private void all_SelectedProductChanged(object sender, SelectedProductChangedArgs e)
        {
            combo_category_name.Text = e.CategoryName;
            combo_product_name.SelectedValue = e.ProductName;
        }


        /////////////////////////////////////////////////////////////////////////////////////

    }
}
