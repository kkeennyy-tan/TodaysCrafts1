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
    public partial class FrmAppConfig : Form
    {
        public FrmAppConfig()
        {
            InitializeComponent();
        }

        private void FrmAppConfig_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("(local)");
            cboServer.Items.Add(@".\SQLEXPRESS01");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS01", Environment.MachineName));
            cboServer.SelectedIndex = 3;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password{3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                FrmSqlHelper helper = new FrmSqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test Connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password{3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                FrmSqlHelper helper = new FrmSqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    FrmAppSetting setting = new FrmAppSetting();
                    setting.SaveConnectionString("con", connectionString);
                    MessageBox.Show("Your Connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
