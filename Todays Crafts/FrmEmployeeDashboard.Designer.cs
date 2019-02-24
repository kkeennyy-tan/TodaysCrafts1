namespace Todays_Crafts
{
    partial class FrmEmployeeDashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.infobtn);
            this.panel2.Controls.Add(this.purchasebtn);
            this.panel2.Controls.Add(this.inventorybtn);
            this.panel2.Controls.Add(this.sidepanel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 746);
            this.panel2.TabIndex = 6;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homebtn.Image = global::Todays_Crafts.Properties.Resources.home;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(18, 174);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(257, 73);
            this.homebtn.TabIndex = 14;
            this.homebtn.Text = "       Home";
            this.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // infobtn
            // 
            this.infobtn.FlatAppearance.BorderSize = 0;
            this.infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.infobtn.Image = global::Todays_Crafts.Properties.Resources.infos;
            this.infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infobtn.Location = new System.Drawing.Point(18, 393);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(257, 73);
            this.infobtn.TabIndex = 13;
            this.infobtn.Text = "       Customer Info";
            this.infobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infobtn.UseVisualStyleBackColor = true;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // purchasebtn
            // 
            this.purchasebtn.FlatAppearance.BorderSize = 0;
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchasebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.purchasebtn.Image = global::Todays_Crafts.Properties.Resources.purchase;
            this.purchasebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasebtn.Location = new System.Drawing.Point(18, 320);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(257, 73);
            this.purchasebtn.TabIndex = 11;
            this.purchasebtn.Text = "       Purchase Order";
            this.purchasebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchasebtn.UseVisualStyleBackColor = true;
            this.purchasebtn.Click += new System.EventHandler(this.purchasebtn_Click);
            // 
            // inventorybtn
            // 
            this.inventorybtn.FlatAppearance.BorderSize = 0;
            this.inventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.inventorybtn.Image = global::Todays_Crafts.Properties.Resources.inventory;
            this.inventorybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventorybtn.Location = new System.Drawing.Point(18, 247);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Size = new System.Drawing.Size(257, 73);
            this.inventorybtn.TabIndex = 10;
            this.inventorybtn.Text = "       Inventory";
            this.inventorybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventorybtn.UseVisualStyleBackColor = true;
            this.inventorybtn.Click += new System.EventHandler(this.inventorybtn_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(169)))), ((int)(((byte)(250)))));
            this.sidepanel.Location = new System.Drawing.Point(1, 174);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(18, 73);
            this.sidepanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(131)))), ((int)(((byte)(154)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblstatus);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 47);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(818, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login As   :";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstatus.Location = new System.Drawing.Point(907, 13);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(53, 20);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "status";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Todays_Crafts.Properties.Resources.shutdown;
            this.button5.Location = new System.Drawing.Point(983, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 38);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmEmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 746);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployeeDashboard";
            this.Load += new System.EventHandler(this.FrmEmployeeDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button button5;
    }
}