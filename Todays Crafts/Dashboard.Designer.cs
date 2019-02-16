namespace Todays_Crafts
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.employeebtn = new System.Windows.Forms.Button();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Todays_Crafts.TodaysCraftsTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Todays_Crafts.TodaysCraftsTableAdapters.employeeTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todaysCrafts = new Todays_Crafts.TodaysCrafts();
            this.lblstatus = new System.Windows.Forms.Label();
            this.homecontrol2 = new Todays_Crafts.homecontrol();
            this.employeecontrol1 = new Todays_Crafts.employeecontrol();
            this.inventorycontrol2 = new Todays_Crafts.inventorycontrol();
            this.purchasecontrol2 = new Todays_Crafts.purchasecontrol();
            this.infocontrol2 = new Todays_Crafts.infocontrol();
            this.employeecontrol2 = new Todays_Crafts.employeecontrol();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.infobtn);
            this.panel2.Controls.Add(this.employeebtn);
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
            this.panel2.TabIndex = 5;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.infobtn.Font = new System.Drawing.Font("Roboto", 12F);
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
            // employeebtn
            // 
            this.employeebtn.FlatAppearance.BorderSize = 0;
            this.employeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeebtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.employeebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.employeebtn.Image = global::Todays_Crafts.Properties.Resources.employee1;
            this.employeebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeebtn.Location = new System.Drawing.Point(18, 466);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(257, 73);
            this.employeebtn.TabIndex = 12;
            this.employeebtn.Text = "       Employee";
            this.employeebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeebtn.UseVisualStyleBackColor = true;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // purchasebtn
            // 
            this.purchasebtn.FlatAppearance.BorderSize = 0;
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasebtn.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.inventorybtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Todays_Crafts.Properties.Resources.shutdown;
            this.button5.Location = new System.Drawing.Point(983, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 38);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_infoTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.purchase_orderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Todays_Crafts.TodaysCraftsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            // 
            // todaysCrafts
            // 
            this.todaysCrafts.DataSetName = "TodaysCrafts";
            this.todaysCrafts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstatus.Location = new System.Drawing.Point(907, 13);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(56, 21);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "status";
            // 
            // homecontrol2
            // 
            this.homecontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.homecontrol2.Location = new System.Drawing.Point(275, 174);
            this.homecontrol2.Name = "homecontrol2";
            this.homecontrol2.Size = new System.Drawing.Size(1025, 572);
            this.homecontrol2.TabIndex = 13;
            // 
            // employeecontrol1
            // 
            this.employeecontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.employeecontrol1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeecontrol1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.employeecontrol1.ForeColor = System.Drawing.SystemColors.Control;
            this.employeecontrol1.Location = new System.Drawing.Point(275, 174);
            this.employeecontrol1.Name = "employeecontrol1";
            this.employeecontrol1.Size = new System.Drawing.Size(1025, 572);
            this.employeecontrol1.TabIndex = 12;
            // 
            // inventorycontrol2
            // 
            this.inventorycontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.inventorycontrol2.Location = new System.Drawing.Point(275, 174);
            this.inventorycontrol2.Name = "inventorycontrol2";
            this.inventorycontrol2.Size = new System.Drawing.Size(1025, 572);
            this.inventorycontrol2.TabIndex = 10;
            // 
            // purchasecontrol2
            // 
            this.purchasecontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.purchasecontrol2.Location = new System.Drawing.Point(275, 174);
            this.purchasecontrol2.Name = "purchasecontrol2";
            this.purchasecontrol2.Size = new System.Drawing.Size(1025, 572);
            this.purchasecontrol2.TabIndex = 9;
            // 
            // infocontrol2
            // 
            this.infocontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.infocontrol2.Location = new System.Drawing.Point(275, 174);
            this.infocontrol2.Name = "infocontrol2";
            this.infocontrol2.Size = new System.Drawing.Size(1025, 572);
            this.infocontrol2.TabIndex = 8;
            // 
            // employeecontrol2
            // 
            this.employeecontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.employeecontrol2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeecontrol2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.employeecontrol2.ForeColor = System.Drawing.SystemColors.Control;
            this.employeecontrol2.Location = new System.Drawing.Point(275, 174);
            this.employeecontrol2.Name = "employeecontrol2";
            this.employeecontrol2.Size = new System.Drawing.Size(1025, 572);
            this.employeecontrol2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(818, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login As   :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 746);
            this.Controls.Add(this.homecontrol2);
            this.Controls.Add(this.employeecontrol1);
            this.Controls.Add(this.inventorycontrol2);
            this.Controls.Add(this.purchasecontrol2);
            this.Controls.Add(this.infocontrol2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCrafts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button homebtn;
        private employeecontrol employeecontrol2;
        private infocontrol infocontrol2;
        private purchasecontrol purchasecontrol2;
        private inventorycontrol inventorycontrol2;
        private employeecontrol employeecontrol1;
        private homecontrol homecontrol2;
        private TodaysCraftsTableAdapters.TableAdapterManager tableAdapterManager;
        private TodaysCraftsTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private TodaysCrafts todaysCrafts;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label2;
    }
}