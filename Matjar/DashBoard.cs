﻿using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Matjar
{
    public partial class DashBoard : Form
    {

        private FormManagement manage;
        public DashBoard()
        {
            InitializeComponent();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            btn_daly_sales.PerformClick();

        }

        private void setButtonsBackColor(object sender)
        {
            Button current = (Button)sender;
            pnl_pointer.Location = new Point(pnl_pointer.Location.X, current.Location.Y);

            Color base_color = Color.FromArgb(64, 64, 64);

            btn_statistics.BackColor = base_color;
            btn_goods.BackColor = base_color;
            btn_purchases.BackColor = base_color;
            btn_daly_sales.BackColor = base_color;
            btn_new_product.BackColor = base_color;

            current.BackColor = Color.Teal;
        }

        private void btn_goods_Click(object sender, EventArgs e)
        {
            setButtonsBackColor(sender);
            storeUC1.BringToFront();
            storeUC1.Start();

        }
        private void btn_daly_sales_Click(object sender, EventArgs e)
        {
            setButtonsBackColor(sender);
            uC_Sales1.BringToFront();
            uC_Sales1.Start();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            setButtonsBackColor(sender);
            uC_Purchases1.BringToFront();
            uC_Purchases1.Start();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            new AddUpdateProductForm().Show();
            setButtonsBackColor(sender);
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            setButtonsBackColor(sender);
            if (manage == null || manage.IsDisposed)
            {
                manage = new FormManagement();
                manage.Show();
            }
        }





    }


}
