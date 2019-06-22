﻿namespace UserControls
{
    partial class StoreUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_store = new System.Windows.Forms.DataGridView();
            this.pnl_right_border = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasing_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit_margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_store
            // 
            this.dgv_store.AllowUserToAddRows = false;
            this.dgv_store.AllowUserToDeleteRows = false;
            this.dgv_store.AllowUserToResizeColumns = false;
            this.dgv_store.AllowUserToResizeRows = false;
            this.dgv_store.BackgroundColor = System.Drawing.Color.White;
            this.dgv_store.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_store.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_store.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_store.ColumnHeadersHeight = 40;
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_store.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.product_id,
            this.product_name,
            this.unit,
            this.amount,
            this.selling_price,
            this.purchasing_price,
            this.profit_margin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_store.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_store.EnableHeadersVisualStyles = false;
            this.dgv_store.Location = new System.Drawing.Point(0, 0);
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_store.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_store.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_store.RowHeadersVisible = false;
            this.dgv_store.RowHeadersWidth = 30;
            this.dgv_store.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_store.RowTemplate.Height = 30;
            this.dgv_store.Size = new System.Drawing.Size(951, 719);
            this.dgv_store.TabIndex = 54;
            // 
            // pnl_right_border
            // 
            this.pnl_right_border.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right_border.Location = new System.Drawing.Point(951, 0);
            this.pnl_right_border.Name = "pnl_right_border";
            this.pnl_right_border.Size = new System.Drawing.Size(2, 719);
            this.pnl_right_border.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 28);
            this.panel2.TabIndex = 56;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "القسم";
            this.category.Name = "category";
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "كود الصنف";
            this.product_id.Name = "product_id";
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "اسم الصنف";
            this.product_name.Name = "product_name";
            this.product_name.Width = 200;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "الوحدة";
            this.unit.Name = "unit";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.amount.HeaderText = "الكمية";
            this.amount.Name = "amount";
            // 
            // selling_price
            // 
            this.selling_price.DataPropertyName = "selling_price";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.selling_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.selling_price.HeaderText = "سعر البيع";
            this.selling_price.Name = "selling_price";
            // 
            // purchasing_price
            // 
            this.purchasing_price.DataPropertyName = "purchasing_price";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.purchasing_price.DefaultCellStyle = dataGridViewCellStyle4;
            this.purchasing_price.HeaderText = "سعر الشراء";
            this.purchasing_price.Name = "purchasing_price";
            // 
            // profit_margin
            // 
            this.profit_margin.DataPropertyName = "profit_margin";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.profit_margin.DefaultCellStyle = dataGridViewCellStyle5;
            this.profit_margin.HeaderText = "هامش الربح";
            this.profit_margin.Name = "profit_margin";
            // 
            // StoreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_store);
            this.Controls.Add(this.pnl_right_border);
            this.Controls.Add(this.panel2);
            this.Name = "StoreUC";
            this.Size = new System.Drawing.Size(953, 747);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_right_border;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_store;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasing_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit_margin;

    }
}