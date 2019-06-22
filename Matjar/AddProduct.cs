using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccessLayer;
using Zen.Barcode;

namespace Matjar
{
    public partial class AddProduct : Form
    {
        public DBHandler db = new DBHandler();
        public bool IsRefresh { get; private set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int new_id = db.lastID(cbx_category_name.Text)+1;
            string category_name, product_name, product_id;
            category_name = "اسم القسم          : " + cbx_category_name.Text;
            product_name = "اسم المنتج الجديد هو : " + txt_product_name.Text;
            product_id = "كود المنتج             : " + new_id.ToString() ;


            string message = category_name + "\n" + product_name + "\n" + product_id + "\n" + "هل تريد الحفظ ؟" ;
            DialogResult result = MessageBox.Show(message,"رسالة ادارية",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            double amount,selling_price ,purchasing_price ;
            double.TryParse(txtCountity.Text,out amount);
            double.TryParse(txtSellingPrice.Text,out selling_price);
            double.TryParse(txtPurchasesPrice.Text,out purchasing_price);
            if ( result == DialogResult.OK)
            {
                db.addNewProduct(int.Parse(cbx_category_id.Text),cbx_category_name.Text,new_id,txt_product_name.Text,cbx_unit.Text,amount,selling_price,purchasing_price);
                IsRefresh = true;
            }
            IsRefresh = false;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            txtCountity.Text = "0";
            txtPurchasesPrice.Text = "0";
            txtSellingPrice.Text = "0";
            System.Data.DataTable units_tbl = db.select(new string[] { "unit" }, "units", "unit");
            System.Data.DataTable categorite = db.select(new string[] { "id", "category" }, "categories", "id");

            cbx_category_id.DataSource = categorite.ColumnToArray(0);
            cbx_category_name.DataSource = categorite.ColumnToArray(1);
            cbx_unit.DataSource = db.select(new string[] { "unit" }, "units", "unit").ColumnToArray(0);
        }

        private void cbx_category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_category_id.SelectedIndex = cbx_category_name.SelectedIndex;
        }

        private void prepair_Click(object sender, EventArgs e)
        {
            if (txt_product_name.Text == "")
                MessageBox.Show("يجب كتابة اسم المنتج");
            else
            {
                int new_id = db.lastID(cbx_category_name.Text) + 1;
                lbl_product_id.Text = new_id.ToString();
                Code128BarcodeDraw bar_code = BarcodeDrawFactory.Code128WithChecksum;
                picture_bar_code.Image = bar_code.Draw(lbl_product_id.Text, 50);
            }
        }

        private void AddProduct_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
        }
    }
}
