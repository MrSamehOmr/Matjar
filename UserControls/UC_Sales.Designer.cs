namespace UserControls
{
    partial class UC_Sales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_day_total = new System.Windows.Forms.Label();
            this.pnl_down = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.combo_id = new System.Windows.Forms.ComboBox();
            this.combo_product_name = new System.Windows.Forms.ComboBox();
            this.btn_cosmetics = new System.Windows.Forms.Button();
            this.btn_other = new System.Windows.Forms.Button();
            this.btn_paperwork = new System.Windows.Forms.Button();
            this.btn_fluids = new System.Windows.Forms.Button();
            this.btn_toilet_soap = new System.Windows.Forms.Button();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.process_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_of_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_automatics = new System.Windows.Forms.Button();
            this.btn_pesticides = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_normals = new System.Windows.Forms.Button();
            this.pnl_control_btns = new System.Windows.Forms.Panel();
            this.date_picker_work_day = new System.Windows.Forms.DateTimePicker();
            this.lbl_work_day = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_right_border = new System.Windows.Forms.Panel();
            this.dgvDailySalesProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.pnl_control_btns.SuspendLayout();
            this.dgvDailySalesProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_day_total
            // 
            this.lbl_day_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_day_total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_total.Location = new System.Drawing.Point(899, 0);
            this.lbl_day_total.Name = "lbl_day_total";
            this.lbl_day_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_day_total.Size = new System.Drawing.Size(101, 28);
            this.lbl_day_total.TabIndex = 3;
            this.lbl_day_total.Text = "0";
            this.lbl_day_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_down
            // 
            this.pnl_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_down.Location = new System.Drawing.Point(810, 41);
            this.pnl_down.Name = "pnl_down";
            this.pnl_down.Size = new System.Drawing.Size(103, 5);
            this.pnl_down.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 60);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(60, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "الكمية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 60);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "الوحدة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_unit
            // 
            this.lbl_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_unit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit.ForeColor = System.Drawing.Color.White;
            this.lbl_unit.Location = new System.Drawing.Point(394, 93);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_unit.Size = new System.Drawing.Size(60, 60);
            this.lbl_unit.TabIndex = 24;
            this.lbl_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 62);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(222, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "الصنف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 60);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "إجمالي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_total.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(193, 93);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(60, 60);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 60);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "السعر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(328, 93);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_price.Size = new System.Drawing.Size(60, 60);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_day_total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 756);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 28);
            this.panel1.TabIndex = 8;
            // 
            // text_quantity
            // 
            this.text_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_quantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_quantity.Location = new System.Drawing.Point(259, 109);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_quantity.Size = new System.Drawing.Size(60, 32);
            this.text_quantity.TabIndex = 10;
            this.text_quantity.Text = "0";
            this.text_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_quantity_MouseClick);
            this.text_quantity.TextChanged += new System.EventHandler(this.text_quantity_TextChanged);
            this.text_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_quantity_KeyDown_1);
            // 
            // combo_id
            // 
            this.combo_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_id.Enabled = false;
            this.combo_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_id.FormattingEnabled = true;
            this.combo_id.Location = new System.Drawing.Point(709, 97);
            this.combo_id.Name = "combo_id";
            this.combo_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_id.Size = new System.Drawing.Size(48, 26);
            this.combo_id.TabIndex = 1;
            // 
            // combo_product_name
            // 
            this.combo_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_product_name.BackColor = System.Drawing.Color.White;
            this.combo_product_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_product_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_product_name.ForeColor = System.Drawing.Color.Black;
            this.combo_product_name.FormattingEnabled = true;
            this.combo_product_name.Location = new System.Drawing.Point(459, 95);
            this.combo_product_name.MaxDropDownItems = 20;
            this.combo_product_name.Name = "combo_product_name";
            this.combo_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_product_name.Size = new System.Drawing.Size(244, 32);
            this.combo_product_name.TabIndex = 9;
            this.combo_product_name.SelectedIndexChanged += new System.EventHandler(this.combo_product_name_SelectedIndexChanged);
            // 
            // btn_cosmetics
            // 
            this.btn_cosmetics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cosmetics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cosmetics.FlatAppearance.BorderSize = 0;
            this.btn_cosmetics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cosmetics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cosmetics.ForeColor = System.Drawing.Color.White;
            this.btn_cosmetics.Location = new System.Drawing.Point(600, 3);
            this.btn_cosmetics.Name = "btn_cosmetics";
            this.btn_cosmetics.Size = new System.Drawing.Size(103, 37);
            this.btn_cosmetics.TabIndex = 3;
            this.btn_cosmetics.Text = "مستحضرات";
            this.btn_cosmetics.UseVisualStyleBackColor = false;
            this.btn_cosmetics.Click += new System.EventHandler(this.btn_cosmetics_Click);
            // 
            // btn_other
            // 
            this.btn_other.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_other.FlatAppearance.BorderSize = 0;
            this.btn_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_other.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_other.ForeColor = System.Drawing.Color.White;
            this.btn_other.Location = new System.Drawing.Point(75, 3);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(103, 37);
            this.btn_other.TabIndex = 8;
            this.btn_other.Text = "اخرى";
            this.btn_other.UseVisualStyleBackColor = false;
            this.btn_other.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // btn_paperwork
            // 
            this.btn_paperwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_paperwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_paperwork.FlatAppearance.BorderSize = 0;
            this.btn_paperwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paperwork.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paperwork.ForeColor = System.Drawing.Color.White;
            this.btn_paperwork.Location = new System.Drawing.Point(390, 3);
            this.btn_paperwork.Name = "btn_paperwork";
            this.btn_paperwork.Size = new System.Drawing.Size(103, 37);
            this.btn_paperwork.TabIndex = 5;
            this.btn_paperwork.Text = "ورقيات";
            this.btn_paperwork.UseVisualStyleBackColor = false;
            this.btn_paperwork.Click += new System.EventHandler(this.btn_paperwork_Click);
            // 
            // btn_fluids
            // 
            this.btn_fluids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fluids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fluids.FlatAppearance.BorderSize = 0;
            this.btn_fluids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fluids.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fluids.ForeColor = System.Drawing.Color.White;
            this.btn_fluids.Location = new System.Drawing.Point(495, 3);
            this.btn_fluids.Name = "btn_fluids";
            this.btn_fluids.Size = new System.Drawing.Size(103, 37);
            this.btn_fluids.TabIndex = 4;
            this.btn_fluids.Text = "سوائل";
            this.btn_fluids.UseVisualStyleBackColor = false;
            this.btn_fluids.Click += new System.EventHandler(this.btn_fluids_Click);
            // 
            // btn_toilet_soap
            // 
            this.btn_toilet_soap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toilet_soap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_toilet_soap.FlatAppearance.BorderSize = 0;
            this.btn_toilet_soap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toilet_soap.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toilet_soap.ForeColor = System.Drawing.Color.White;
            this.btn_toilet_soap.Location = new System.Drawing.Point(180, 3);
            this.btn_toilet_soap.Name = "btn_toilet_soap";
            this.btn_toilet_soap.Size = new System.Drawing.Size(103, 37);
            this.btn_toilet_soap.TabIndex = 7;
            this.btn_toilet_soap.Text = "صابون تواليت";
            this.btn_toilet_soap.UseVisualStyleBackColor = false;
            this.btn_toilet_soap.Click += new System.EventHandler(this.btn_toilet_soap_Click);
            // 
            // dgv_sales
            // 
            this.dgv_sales.AllowUserToAddRows = false;
            this.dgv_sales.AllowUserToDeleteRows = false;
            this.dgv_sales.AllowUserToResizeColumns = false;
            this.dgv_sales.AllowUserToResizeRows = false;
            this.dgv_sales.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_sales.ColumnHeadersHeight = 40;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process_id,
            this.category_name,
            this.product_id,
            this.product_name,
            this.unit_name,
            this.amount,
            this.price,
            this.total,
            this.time_of_sale});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sales.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sales.EnableHeadersVisualStyles = false;
            this.dgv_sales.Location = new System.Drawing.Point(0, 169);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_sales.RowHeadersWidth = 30;
            this.dgv_sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_sales.RowTemplate.Height = 30;
            this.dgv_sales.Size = new System.Drawing.Size(1000, 587);
            this.dgv_sales.TabIndex = 7;
            this.dgv_sales.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_sales_CellMouseClick);
            // 
            // process_id
            // 
            this.process_id.DataPropertyName = "process_id";
            this.process_id.HeaderText = "كود العملية";
            this.process_id.Name = "process_id";
            this.process_id.ReadOnly = true;
            this.process_id.Width = 150;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "القسم";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "كود الصنف";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 50;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "اسم الصنف";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 200;
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "الوحدة";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            this.unit_name.Width = 50;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle9;
            this.amount.HeaderText = "الكمية";
            this.amount.Name = "amount";
            this.amount.Width = 70;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle10;
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 90;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle11;
            this.total.HeaderText = "الإجمالي";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 90;
            // 
            // time_of_sale
            // 
            this.time_of_sale.DataPropertyName = "time_of_sale";
            dataGridViewCellStyle12.Format = "T";
            dataGridViewCellStyle12.NullValue = null;
            this.time_of_sale.DefaultCellStyle = dataGridViewCellStyle12;
            this.time_of_sale.HeaderText = "وقت البيع";
            this.time_of_sale.Name = "time_of_sale";
            this.time_of_sale.ReadOnly = true;
            // 
            // btn_automatics
            // 
            this.btn_automatics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_automatics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_automatics.FlatAppearance.BorderSize = 0;
            this.btn_automatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_automatics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_automatics.ForeColor = System.Drawing.Color.White;
            this.btn_automatics.Location = new System.Drawing.Point(705, 3);
            this.btn_automatics.Name = "btn_automatics";
            this.btn_automatics.Size = new System.Drawing.Size(103, 37);
            this.btn_automatics.TabIndex = 1;
            this.btn_automatics.Text = "مساحيق اتوماتيك";
            this.btn_automatics.UseVisualStyleBackColor = false;
            this.btn_automatics.Click += new System.EventHandler(this.btn_automatics_Click);
            // 
            // btn_pesticides
            // 
            this.btn_pesticides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesticides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pesticides.FlatAppearance.BorderSize = 0;
            this.btn_pesticides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesticides.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesticides.ForeColor = System.Drawing.Color.White;
            this.btn_pesticides.Location = new System.Drawing.Point(285, 3);
            this.btn_pesticides.Name = "btn_pesticides";
            this.btn_pesticides.Size = new System.Drawing.Size(103, 37);
            this.btn_pesticides.TabIndex = 6;
            this.btn_pesticides.Text = "مبيدات";
            this.btn_pesticides.UseVisualStyleBackColor = false;
            this.btn_pesticides.Click += new System.EventHandler(this.btn_pesticides_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(127, 93);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 60);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_normals
            // 
            this.btn_normals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_normals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_normals.FlatAppearance.BorderSize = 0;
            this.btn_normals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normals.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_normals.ForeColor = System.Drawing.Color.White;
            this.btn_normals.Location = new System.Drawing.Point(810, 3);
            this.btn_normals.Name = "btn_normals";
            this.btn_normals.Size = new System.Drawing.Size(103, 37);
            this.btn_normals.TabIndex = 0;
            this.btn_normals.Text = "مساحيق عادية";
            this.btn_normals.UseVisualStyleBackColor = false;
            this.btn_normals.Click += new System.EventHandler(this.btn_normals_Click);
            // 
            // pnl_control_btns
            // 
            this.pnl_control_btns.Controls.Add(this.date_picker_work_day);
            this.pnl_control_btns.Controls.Add(this.pnl_down);
            this.pnl_control_btns.Controls.Add(this.label9);
            this.pnl_control_btns.Controls.Add(this.label6);
            this.pnl_control_btns.Controls.Add(this.lbl_work_day);
            this.pnl_control_btns.Controls.Add(this.lbl_clock);
            this.pnl_control_btns.Controls.Add(this.lbl_unit);
            this.pnl_control_btns.Controls.Add(this.label8);
            this.pnl_control_btns.Controls.Add(this.label5);
            this.pnl_control_btns.Controls.Add(this.lbl_total);
            this.pnl_control_btns.Controls.Add(this.label4);
            this.pnl_control_btns.Controls.Add(this.lbl_price);
            this.pnl_control_btns.Controls.Add(this.text_quantity);
            this.pnl_control_btns.Controls.Add(this.combo_id);
            this.pnl_control_btns.Controls.Add(this.combo_product_name);
            this.pnl_control_btns.Controls.Add(this.btn_cosmetics);
            this.pnl_control_btns.Controls.Add(this.btn_other);
            this.pnl_control_btns.Controls.Add(this.btn_paperwork);
            this.pnl_control_btns.Controls.Add(this.btn_fluids);
            this.pnl_control_btns.Controls.Add(this.btn_toilet_soap);
            this.pnl_control_btns.Controls.Add(this.btn_automatics);
            this.pnl_control_btns.Controls.Add(this.btn_pesticides);
            this.pnl_control_btns.Controls.Add(this.btn_save);
            this.pnl_control_btns.Controls.Add(this.button1);
            this.pnl_control_btns.Controls.Add(this.btn_normals);
            this.pnl_control_btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_control_btns.Location = new System.Drawing.Point(0, 0);
            this.pnl_control_btns.Name = "pnl_control_btns";
            this.pnl_control_btns.Size = new System.Drawing.Size(1000, 169);
            this.pnl_control_btns.TabIndex = 6;
            // 
            // date_picker_work_day
            // 
            this.date_picker_work_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_picker_work_day.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_work_day.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.date_picker_work_day.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_picker_work_day.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_work_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker_work_day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_picker_work_day.Location = new System.Drawing.Point(782, 130);
            this.date_picker_work_day.Name = "date_picker_work_day";
            this.date_picker_work_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_picker_work_day.RightToLeftLayout = true;
            this.date_picker_work_day.Size = new System.Drawing.Size(148, 22);
            this.date_picker_work_day.TabIndex = 25;
            this.date_picker_work_day.Value = new System.DateTime(2019, 6, 6, 0, 0, 0, 0);
            this.date_picker_work_day.ValueChanged += new System.EventHandler(this.workDay_ValueChanged);
            // 
            // lbl_work_day
            // 
            this.lbl_work_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_work_day.BackColor = System.Drawing.Color.White;
            this.lbl_work_day.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_work_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_work_day.Location = new System.Drawing.Point(782, 97);
            this.lbl_work_day.Name = "lbl_work_day";
            this.lbl_work_day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_work_day.Size = new System.Drawing.Size(152, 30);
            this.lbl_work_day.TabIndex = 24;
            this.lbl_work_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clock.BackColor = System.Drawing.Color.White;
            this.lbl_clock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_clock.Location = new System.Drawing.Point(782, 65);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_clock.Size = new System.Drawing.Size(152, 30);
            this.lbl_clock.TabIndex = 24;
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(61, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "فاتورة";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnl_right_border
            // 
            this.pnl_right_border.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right_border.Location = new System.Drawing.Point(1000, 0);
            this.pnl_right_border.Name = "pnl_right_border";
            this.pnl_right_border.Size = new System.Drawing.Size(2, 784);
            this.pnl_right_border.TabIndex = 14;
            // 
            // dgvDailySalesProperties
            // 
            this.dgvDailySalesProperties.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDailySalesProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete});
            this.dgvDailySalesProperties.Name = "dgvDailySalesProperties";
            this.dgvDailySalesProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDailySalesProperties.Size = new System.Drawing.Size(101, 26);
            this.dgvDailySalesProperties.Text = "خيارات";
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 22);
            this.delete.Text = "حذف";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // UC_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.pnl_control_btns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_right_border);
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(1002, 784);
            this.Load += new System.EventHandler(this.UC_DailySales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.pnl_control_btns.ResumeLayout(false);
            this.pnl_control_btns.PerformLayout();
            this.dgvDailySalesProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_day_total;
        private System.Windows.Forms.Panel pnl_down;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.ComboBox combo_id;
        private System.Windows.Forms.ComboBox combo_product_name;
        private System.Windows.Forms.Button btn_cosmetics;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.Button btn_paperwork;
        private System.Windows.Forms.Button btn_fluids;
        private System.Windows.Forms.Button btn_toilet_soap;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button btn_automatics;
        private System.Windows.Forms.Button btn_pesticides;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_normals;
        private System.Windows.Forms.Panel pnl_control_btns;
        private System.Windows.Forms.Panel pnl_right_border;
        private System.Windows.Forms.ContextMenuStrip dgvDailySalesProperties;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.DateTimePicker date_picker_work_day;
        private System.Windows.Forms.Label lbl_work_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_of_sale;
    }
}
