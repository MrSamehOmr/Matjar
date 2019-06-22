namespace Matjar
{
    partial class AddProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_unit = new System.Windows.Forms.ComboBox();
            this.cbx_category_name = new System.Windows.Forms.ComboBox();
            this.cbx_category_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.prepair = new System.Windows.Forms.Button();
            this.picture_bar_code = new System.Windows.Forms.PictureBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtCountity = new System.Windows.Forms.TextBox();
            this.txtPurchasesPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bar_code)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 123);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 53;
            this.label6.Text = "الوحدة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_unit
            // 
            this.cbx_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_unit.BackColor = System.Drawing.Color.White;
            this.cbx_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_unit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_unit.FormattingEnabled = true;
            this.cbx_unit.Location = new System.Drawing.Point(212, 121);
            this.cbx_unit.MaxDropDownItems = 20;
            this.cbx_unit.Name = "cbx_unit";
            this.cbx_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_unit.Size = new System.Drawing.Size(135, 32);
            this.cbx_unit.TabIndex = 2;
            // 
            // cbx_category_name
            // 
            this.cbx_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_category_name.BackColor = System.Drawing.Color.White;
            this.cbx_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_category_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_category_name.FormattingEnabled = true;
            this.cbx_category_name.Location = new System.Drawing.Point(107, 35);
            this.cbx_category_name.MaxDropDownItems = 20;
            this.cbx_category_name.Name = "cbx_category_name";
            this.cbx_category_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_category_name.Size = new System.Drawing.Size(240, 32);
            this.cbx_category_name.TabIndex = 0;
            this.cbx_category_name.SelectedIndexChanged += new System.EventHandler(this.cbx_category_name_SelectedIndexChanged);
            // 
            // cbx_category_id
            // 
            this.cbx_category_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_category_id.BackColor = System.Drawing.Color.White;
            this.cbx_category_id.Enabled = false;
            this.cbx_category_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_category_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_category_id.FormattingEnabled = true;
            this.cbx_category_id.Location = new System.Drawing.Point(39, 41);
            this.cbx_category_id.Name = "cbx_category_id";
            this.cbx_category_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_category_id.Size = new System.Drawing.Size(62, 26);
            this.cbx_category_id.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 79);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(70, 30);
            this.label8.TabIndex = 52;
            this.label8.Text = "الصنف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 35);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 51;
            this.label12.Text = "القسم";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(107, 84);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_name.Size = new System.Drawing.Size(240, 25);
            this.txt_product_name.TabIndex = 1;
            this.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_id.Location = new System.Drawing.Point(107, 123);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_product_id.Size = new System.Drawing.Size(70, 30);
            this.lbl_product_id.TabIndex = 73;
            this.lbl_product_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prepair
            // 
            this.prepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prepair.FlatAppearance.BorderSize = 0;
            this.prepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prepair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepair.ForeColor = System.Drawing.Color.Transparent;
            this.prepair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prepair.Location = new System.Drawing.Point(125, 238);
            this.prepair.Name = "prepair";
            this.prepair.Size = new System.Drawing.Size(70, 41);
            this.prepair.TabIndex = 6;
            this.prepair.Text = "تجهيز";
            this.prepair.UseVisualStyleBackColor = false;
            this.prepair.Click += new System.EventHandler(this.prepair_Click);
            // 
            // picture_bar_code
            // 
            this.picture_bar_code.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picture_bar_code.Location = new System.Drawing.Point(335, 238);
            this.picture_bar_code.Name = "picture_bar_code";
            this.picture_bar_code.Size = new System.Drawing.Size(118, 41);
            this.picture_bar_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_bar_code.TabIndex = 74;
            this.picture_bar_code.TabStop = false;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(322, 198);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSellingPrice.Size = new System.Drawing.Size(41, 25);
            this.txtSellingPrice.TabIndex = 3;
            this.txtSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSellingPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProduct_MouseClick);
            // 
            // txtCountity
            // 
            this.txtCountity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountity.Location = new System.Drawing.Point(225, 198);
            this.txtCountity.Name = "txtCountity";
            this.txtCountity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountity.Size = new System.Drawing.Size(41, 25);
            this.txtCountity.TabIndex = 4;
            this.txtCountity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCountity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProduct_MouseClick);
            // 
            // txtPurchasesPrice
            // 
            this.txtPurchasesPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchasesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchasesPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasesPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasesPrice.Location = new System.Drawing.Point(133, 198);
            this.txtPurchasesPrice.Name = "txtPurchasesPrice";
            this.txtPurchasesPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPurchasesPrice.Size = new System.Drawing.Size(41, 25);
            this.txtPurchasesPrice.TabIndex = 5;
            this.txtPurchasesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPurchasesPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProduct_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 165);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "سعر البيع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 165);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 53;
            this.label2.Text = "الكمية";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 165);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 53;
            this.label3.Text = "سعر الشراء";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 332);
            this.Controls.Add(this.picture_bar_code);
            this.Controls.Add(this.lbl_product_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prepair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_unit);
            this.Controls.Add(this.cbx_category_name);
            this.Controls.Add(this.cbx_category_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPurchasesPrice);
            this.Controls.Add(this.txtCountity);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.label12);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف جديد";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProduct_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picture_bar_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_unit;
        private System.Windows.Forms.ComboBox cbx_category_name;
        private System.Windows.Forms.ComboBox cbx_category_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label lbl_product_id;
        private System.Windows.Forms.Button prepair;
        private System.Windows.Forms.PictureBox picture_bar_code;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtCountity;
        private System.Windows.Forms.TextBox txtPurchasesPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}