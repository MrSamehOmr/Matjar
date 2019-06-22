namespace Matjar
{
    partial class AddUpdateProductForm
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
            this.gMessagesPanel1 = new GControls.GMessagesPanel();
            this.gButton2 = new GControls.GButton();
            this.gButton1 = new GControls.GButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Add_Product_Full1 = new UserControls.UC_Add_Product_Full();
            this.gMessagesPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMessagesPanel1
            // 
            this.gMessagesPanel1.Controls.Add(this.gButton2);
            this.gMessagesPanel1.Controls.Add(this.gButton1);
            this.gMessagesPanel1.Controls.Add(this.label2);
            this.gMessagesPanel1.Controls.Add(this.label1);
            this.gMessagesPanel1.Controls.Add(this.panel1);
            this.gMessagesPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gMessagesPanel1.Location = new System.Drawing.Point(0, 0);
            this.gMessagesPanel1.Name = "gMessagesPanel1";
            this.gMessagesPanel1.Size = new System.Drawing.Size(235, 711);
            this.gMessagesPanel1.TabIndex = 1;
            // 
            // gButton2
            // 
            this.gButton2.FlatAppearance.BorderSize = 0;
            this.gButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.gButton2.Location = new System.Drawing.Point(106, 278);
            this.gButton2.Name = "gButton2";
            this.gButton2.Size = new System.Drawing.Size(75, 42);
            this.gButton2.TabIndex = 3;
            this.gButton2.Text = "OK";
            this.gButton2.UseVisualStyleBackColor = true;
            this.gButton2.Visible = false;
            // 
            // gButton1
            // 
            this.gButton1.FlatAppearance.BorderSize = 0;
            this.gButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.gButton1.Location = new System.Drawing.Point(25, 278);
            this.gButton1.Name = "gButton1";
            this.gButton1.Size = new System.Drawing.Size(75, 42);
            this.gButton1.TabIndex = 3;
            this.gButton1.Text = "OK";
            this.gButton1.UseVisualStyleBackColor = true;
            this.gButton1.Visible = false;
            this.gButton1.Click += new System.EventHandler(this.gButton1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 189);
            this.label2.TabIndex = 2;
            this.label2.Text = "رسالة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "رسالة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 711);
            this.panel1.TabIndex = 0;
            // 
            // uC_Add_Product_Full1
            // 
            this.uC_Add_Product_Full1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Add_Product_Full1.Location = new System.Drawing.Point(235, 0);
            this.uC_Add_Product_Full1.Name = "uC_Add_Product_Full1";
            this.uC_Add_Product_Full1.Size = new System.Drawing.Size(584, 711);
            this.uC_Add_Product_Full1.TabIndex = 0;
            // 
            // AddUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 711);
            this.Controls.Add(this.uC_Add_Product_Full1);
            this.Controls.Add(this.gMessagesPanel1);
            this.Name = "AddUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateProductForm";
            this.gMessagesPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_Add_Product_Full uC_Add_Product_Full1;
        private GControls.GMessagesPanel gMessagesPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GControls.GButton gButton2;
        private GControls.GButton gButton1;
    }
}