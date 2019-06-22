namespace UserControls
{
    partial class FormExistedDataMessage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_existing_products = new System.Windows.Forms.DataGridView();
            this.data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existed_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.save_or_cancel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existing_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_existing_products
            // 
            this.dgv_existing_products.AllowUserToAddRows = false;
            this.dgv_existing_products.AllowUserToDeleteRows = false;
            this.dgv_existing_products.AllowUserToResizeColumns = false;
            this.dgv_existing_products.AllowUserToResizeRows = false;
            this.dgv_existing_products.BackgroundColor = System.Drawing.Color.White;
            this.dgv_existing_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_existing_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_existing_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_existing_products.ColumnHeadersHeight = 40;
            this.dgv_existing_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_existing_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_name,
            this.existed_data,
            this.new_data});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_existing_products.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_existing_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_existing_products.EnableHeadersVisualStyles = false;
            this.dgv_existing_products.Location = new System.Drawing.Point(0, 66);
            this.dgv_existing_products.Name = "dgv_existing_products";
            this.dgv_existing_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_existing_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_existing_products.RowHeadersWidth = 30;
            this.dgv_existing_products.RowTemplate.Height = 30;
            this.dgv_existing_products.Size = new System.Drawing.Size(332, 219);
            this.dgv_existing_products.TabIndex = 47;
            // 
            // data_name
            // 
            this.data_name.DataPropertyName = "data_name";
            this.data_name.HeaderText = "البيان";
            this.data_name.Name = "data_name";
            // 
            // existed_data
            // 
            this.existed_data.DataPropertyName = "existed_data";
            this.existed_data.HeaderText = "البيانات الموجودة";
            this.existed_data.Name = "existed_data";
            // 
            // new_data
            // 
            this.new_data.DataPropertyName = "new_data";
            this.new_data.HeaderText = "البيانات الجديدة";
            this.new_data.Name = "new_data";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(160, 40);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_product_name.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(0, 18);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_product_name.Size = new System.Drawing.Size(332, 48);
            this.lbl_product_name.TabIndex = 48;
            this.lbl_product_name.Text = "اسم القسم  و اسم المنتج";
            this.lbl_product_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.Location = new System.Drawing.Point(168, 6);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(160, 40);
            this.btn_ok.TabIndex = 49;
            this.btn_ok.Text = "حفظ";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 55);
            this.panel1.TabIndex = 51;
            // 
            // lbl_header
            // 
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.Red;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_header.Size = new System.Drawing.Size(332, 18);
            this.lbl_header.TabIndex = 52;
            this.lbl_header.Text = "هذه البيانات موجودة بالفعل و سيتم تعديلها";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_or_cancel
            // 
            this.save_or_cancel.AutoSize = true;
            this.save_or_cancel.Location = new System.Drawing.Point(94, 253);
            this.save_or_cancel.Name = "save_or_cancel";
            this.save_or_cancel.Size = new System.Drawing.Size(101, 17);
            this.save_or_cancel.TabIndex = 53;
            this.save_or_cancel.Text = "save_or_cancel";
            this.save_or_cancel.UseVisualStyleBackColor = true;
            // 
            // FormExistedDataMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(332, 340);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_existing_products);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.save_or_cancel);
            this.Name = "FormExistedDataMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExistedDataMessage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existing_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_existing_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn existed_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_data;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.CheckBox save_or_cancel;
    }
}