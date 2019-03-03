using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todays_Crafts
{
    public partial class FrmEmployeeDashboard : Form
    {
        public FrmEmployeeDashboard(string status)
        {
            InitializeComponent();
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            lblstatus.Text = status;
        }

        private void FrmEmployeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            //homecontrol1.BringToFront();
            homebtn.BackColor = Color.FromArgb(238, 96, 138);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            //employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = inventorybtn.Height;
            sidepanel.Top = inventorybtn.Top;
            //inventorycontrol2.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(255, 190, 190);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            //employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = purchasebtn.Height;
            sidepanel.Top = purchasebtn.Top;
            //purchasecontrol1.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(147, 170, 255);
            infobtn.BackColor = Color.FromArgb(58, 69, 88);
            //employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = infobtn.Height;
            sidepanel.Top = infobtn.Top;
            //infocontrol2.BringToFront();
            homebtn.BackColor = Color.FromArgb(58, 69, 88);
            inventorybtn.BackColor = Color.FromArgb(58, 69, 88);
            purchasebtn.BackColor = Color.FromArgb(58, 69, 88);
            infobtn.BackColor = Color.FromArgb(255, 153, 220);
            //employeebtn.BackColor = Color.FromArgb(58, 69, 88);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login da = new Login();
            da.Show();
        }
    }
}
