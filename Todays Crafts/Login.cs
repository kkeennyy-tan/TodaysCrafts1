using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Todays_Crafts
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BUHG7VK\SQLEXPRESS01;Initial Catalog=TodaysCrafts;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }



        private void Uname_Click(object sender, EventArgs e)
        {
            uname.Clear();
            panel1.BackColor = Color.FromArgb(238, 96, 138);
            uname.ForeColor = Color.FromArgb(238, 96, 138);
            
            panel2.BackColor = Color.WhiteSmoke;
            password.ForeColor = Color.WhiteSmoke;
        }


        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
            panel2.BackColor = Color.FromArgb(238, 96, 138);
            password.ForeColor = Color.FromArgb(238, 96, 138);

            panel1.BackColor = Color.WhiteSmoke;
            uname.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Environment.Exit(0);
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT status from admin WHERE username = '" + uname.Text + "' and password = '" + password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString()=="master")
                {
                    Dashboard da = new Dashboard(dt.Rows[0][0].ToString());
                    da.Show();
                }
                else if (dt.Rows[0][0].ToString() == "user")
                {
                    FrmUserDashboard da= new FrmUserDashboard (dt.Rows[0][0].ToString());
                    da.Show();
                }
            }
        }
    }
}
