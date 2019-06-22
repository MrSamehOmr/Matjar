using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class FormExistedDataMessage : Form
    {
        private DialogResult Result { get; set; }
        public FormExistedDataMessage()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(string category, List<string> product_data)
        {
            lbl_product_name.Text = category + "  ( " + product_data[0] + " )";
            lbl_header.ForeColor = Color.DarkOliveGreen;
            lbl_header.Text = "البيانات الجديدة التي سيتم ادخالها";

            dgv_existing_products.Rows.Add("الوحدة", "", product_data[1]);
            dgv_existing_products.Rows.Add("العدد", "", product_data[2]);
            dgv_existing_products.Rows.Add("سعر الشراء", "", product_data[3]);
            dgv_existing_products.Rows.Add("سعر البيع", "", product_data[4]);
            dgv_existing_products.Rows.Add("هامش الربح", "", product_data[5]);

            dgv_existing_products.Columns[1].Visible = false;
            dgv_existing_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.ShowDialog();
            return this.Result;
        }

        public DialogResult ShowDialog(string category, Product existed_product, List<string> new_data)
        {
            FillGridView(category, existed_product, new_data);
            this.ShowDialog();
            return this.Result;
        }
        public void FillGridView(string category, Product existed_product, List<string> new_data)
        {
            lbl_product_name.Text = category + "  ( " + existed_product.product_name + " )";

            dgv_existing_products.Rows.Add("الوحدة", existed_product.unit_name, new_data[0]);
            dgv_existing_products.Rows.Add("العدد", existed_product.amount, new_data[1]);
            dgv_existing_products.Rows.Add("سعر الشراء", existed_product.purchaning_price, new_data[2]);
            dgv_existing_products.Rows.Add("سعر البيع", existed_product.selling_price, new_data[3]);
            dgv_existing_products.Rows.Add("هامش الربح", existed_product.profit_margin, new_data[4]);
        }

        private void dgv_existing_products_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Result = System.Windows.Forms.DialogResult.OK;
            save_or_cancel.Checked = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Result = System.Windows.Forms.DialogResult.Cancel;
            save_or_cancel.Checked = false;
            this.Close();
        }
    }
}
