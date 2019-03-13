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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.infobtn = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.employeebtn = new System.Windows.Forms.Button();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Todays_Crafts.TodaysCraftsTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Todays_Crafts.TodaysCraftsTableAdapters.employeeTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todaysCrafts = new Todays_Crafts.TodaysCrafts();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.homecontrol1 = new Todays_Crafts.homecontrol();
            this.purchasecontrol1 = new Todays_Crafts.purchasecontrol();
            this.inventorycontrol2 = new Todays_Crafts.inventorycontrol();
            this.infocontrol2 = new Todays_Crafts.infocontrol();
            this.employeecontrol1 = new Todays_Crafts.employeecontrol();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaysCrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Controls.Add(this.infobtn);
            this.panel2.Controls.Add(this.lblGreeting);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
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
            this.infobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.infobtn.FlatAppearance.BorderSize = 0;
            this.infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.infobtn.Image = global::Todays_Crafts.Properties.Resources.infos;
            this.infobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infobtn.Location = new System.Drawing.Point(18, 396);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(257, 73);
            this.infobtn.TabIndex = 13;
            this.infobtn.Text = "       Customer Info";
            this.infobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Lato", 12F);
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGreeting.Location = new System.Drawing.Point(14, 14);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(70, 19);
            this.lblGreeting.TabIndex = 18;
            this.lblGreeting.Text = "Greeting";
            // 
            // employeebtn
            // 
            this.employeebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.employeebtn.FlatAppearance.BorderSize = 0;
            this.employeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.employeebtn.Image = global::Todays_Crafts.Properties.Resources.employee1;
            this.employeebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeebtn.Location = new System.Drawing.Point(18, 470);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(257, 73);
            this.employeebtn.TabIndex = 12;
            this.employeebtn.Text = "       Employee";
            this.employeebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeebtn.UseVisualStyleBackColor = false;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // purchasebtn
            // 
            this.purchasebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.purchasebtn.FlatAppearance.BorderSize = 0;
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.purchasebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.purchasebtn.Image = global::Todays_Crafts.Properties.Resources.purchase;
            this.purchasebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasebtn.Location = new System.Drawing.Point(18, 322);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Size = new System.Drawing.Size(257, 73);
            this.purchasebtn.TabIndex = 11;
            this.purchasebtn.Text = "       Purchase Order";
            this.purchasebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchasebtn.UseVisualStyleBackColor = false;
            this.purchasebtn.Click += new System.EventHandler(this.purchasebtn_Click);
            // 
            // inventorybtn
            // 
            this.inventorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.inventorybtn.FlatAppearance.BorderSize = 0;
            this.inventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.inventorybtn.Image = global::Todays_Crafts.Properties.Resources.inventory;
            this.inventorybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventorybtn.Location = new System.Drawing.Point(18, 248);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Size = new System.Drawing.Size(257, 73);
            this.inventorybtn.TabIndex = 10;
            this.inventorybtn.Text = "       Inventory";
            this.inventorybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventorybtn.UseVisualStyleBackColor = false;
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
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblstatus);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 47);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(907, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 35);
            this.panel5.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(965, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 35);
            this.panel4.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(916, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 41);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(729, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login As   :";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Lato", 12F);
            this.lblstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstatus.Location = new System.Drawing.Point(831, 14);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 19);
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
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lato", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.lblTime.Location = new System.Drawing.Point(996, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 19);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lato", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.lblDate.Location = new System.Drawing.Point(1091, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 19);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            // 
            // homecontrol1
            // 
            this.homecontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.homecontrol1.Location = new System.Drawing.Point(275, 174);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(1025, 572);
            this.homecontrol1.TabIndex = 17;
            // 
            // purchasecontrol1
            // 
            this.purchasecontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.purchasecontrol1.Location = new System.Drawing.Point(275, 174);
            this.purchasecontrol1.Name = "purchasecontrol1";
            this.purchasecontrol1.Size = new System.Drawing.Size(1025, 572);
            this.purchasecontrol1.TabIndex = 16;
            // 
            // inventorycontrol2
            // 
            this.inventorycontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.inventorycontrol2.Location = new System.Drawing.Point(275, 174);
            this.inventorycontrol2.Name = "inventorycontrol2";
            this.inventorycontrol2.Size = new System.Drawing.Size(1025, 572);
            this.inventorycontrol2.TabIndex = 15;
            // 
            // infocontrol2
            // 
            this.infocontrol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.infocontrol2.Location = new System.Drawing.Point(275, 174);
            this.infocontrol2.Name = "infocontrol2";
            this.infocontrol2.Size = new System.Drawing.Size(1025, 572);
            this.infocontrol2.TabIndex = 8;
            // 
            // employeecontrol1
            // 
            this.employeecontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.employeecontrol1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeecontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeecontrol1.ForeColor = System.Drawing.SystemColors.Control;
            this.employeecontrol1.Location = new System.Drawing.Point(275, 174);
            this.employeecontrol1.Name = "employeecontrol1";
            this.employeecontrol1.Size = new System.Drawing.Size(1025, 572);
            this.employeecontrol1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Todays_Crafts.Properties.Resources.employee1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 73);
            this.button2.TabIndex = 12;
            this.button2.Text = "       Job Order";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Todays_Crafts.Properties.Resources.employee1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(18, 618);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 73);
            this.button3.TabIndex = 12;
            this.button3.Text = "       Settings";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 746);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.homecontrol1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.purchasecontrol1);
            this.Controls.Add(this.inventorycontrol2);
            this.Controls.Add(this.infocontrol2);
            this.Controls.Add(this.employeecontrol1);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button homebtn;
        private TodaysCraftsTableAdapters.TableAdapterManager tableAdapterManager;
        private TodaysCraftsTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private TodaysCrafts todaysCrafts;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label2;
        private infocontrol infocontrol1;
        private inventorycontrol inventorycontrol1;
        private homecontrol homecontrol1;
        private System.Windows.Forms.Panel sidepanel;
        private employeecontrol employeecontrol1;
        private infocontrol infocontrol2;
        private inventorycontrol inventorycontrol2;
        private purchasecontrol purchasecontrol1;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}