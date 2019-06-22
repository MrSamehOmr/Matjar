using System;
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
    public partial class StoreUC : UserControl
    {
        private DBHandler db;
        public StoreUC()
        {
            InitializeComponent();
            dgv_store.DoubleBuffered(true);
        }

        public void Start()
        {
            if (db == null)
            {
                db = new DBHandler();
                string all_products_query = string.Format(@"
SELECT categories.category,
       products.product_id,
       products_names.product_name,
       units.unit,
       products.amount,
       products.selling_price,
       products.purchasing_price,
       products.profit_margin
  FROM products
       JOIN
       categories ON products.category_id = categories.id
       JOIN
       units ON products.unit_id = units.id
       JOIN
       products_names ON products.product_name_id = products_names.product_name_id
 ORDER BY categories.id,
          products_names.product_name;
");
                DataTable data = db.ExecuteSQL(all_products_query);
                dgv_store.DataSource = data;
            }
        }
    }
}
