using DataAccessLayer;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Matjar
{
    public partial class AddUpdateProductForm : Form
    {
        public DataTable CategoriesTable { get; private set; }
        public DataTable UnitsTable { get; private set; }
        DBHandler db = new DBHandler();

        public AddUpdateProductForm()
        {
            InitializeComponent();
            CategoriesTable = db.ExecuteSQL("SELECT id, category FROM categories");
            UnitsTable = db.ExecuteSQL("SELECT id, unit FROM units ORDER BY unit");
            uC_Add_Product_Full1.Start(CategoriesTable, UnitsTable);
            uC_Add_Product_Full1.SendMessage += uC_Add_Product_Full1_SendMessage;
        }

        private void uC_Add_Product_Full1_SendMessage(object sender, GControls.MessageArgs e)
        {
            label2.Visible = true;
            label1.Visible = true;

            label1.Text = e.MessageTitle;
            label2.Text = e.Text;
            gButton1.Visible = true;
            gButton2.Visible = true;
            if (e.State == GControls.GMessage.MessageState.Error)
                label1.BackColor = Color.Gold;
        }

        private void gButton1_Click(object sender, System.EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = false;

            gButton1.Visible = false;
            gButton2.Visible = false;
        }

    }
}
