namespace Todays_Crafts
{
    partial class Login
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
            this.uname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sign_in = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.Color.White;
            this.uname.HideSelection = false;
            this.uname.Location = new System.Drawing.Point(100, 247);
            this.uname.MaxLength = 20;
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(239, 20);
            this.uname.TabIndex = 1;
            this.uname.TabStop = false;
            this.uname.Text = "Username";
            this.uname.Click += new System.EventHandler(this.Uname_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(70, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(70, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 1);
            this.panel2.TabIndex = 6;
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in.FlatAppearance.BorderSize = 0;
            this.sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in.Font = new System.Drawing.Font("Roboto", 11F);
            this.sign_in.ForeColor = System.Drawing.Color.White;
            this.sign_in.Location = new System.Drawing.Point(70, 338);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(269, 39);
            this.sign_in.TabIndex = 3;
            this.sign_in.Text = "Sign In";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Roboto", 11F);
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(70, 398);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(269, 39);
            this.register.TabIndex = 4;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(129, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "COPYRIGHT 2019 | KENNY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Todays_Crafts.Properties.Resources._1x1_circle;
            this.pictureBox1.Location = new System.Drawing.Point(87, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picuser
            // 
            this.picuser.Image = global::Todays_Crafts.Properties.Resources.user;
            this.picuser.Location = new System.Drawing.Point(70, 243);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(24, 24);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser.TabIndex = 1;
            this.picuser.TabStop = false;
            // 
            // picpass
            // 
            this.picpass.Image = global::Todays_Crafts.Properties.Resources.password;
            this.picpass.Location = new System.Drawing.Point(70, 289);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(24, 24);
            this.picpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpass.TabIndex = 9;
            this.picpass.TabStop = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HideSelection = false;
            this.password.Location = new System.Drawing.Point(100, 291);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(239, 20);
            this.password.TabIndex = 2;
            this.password.TabStop = false;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Roboto", 6F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(389, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(409, 534);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button exit;
    }
}