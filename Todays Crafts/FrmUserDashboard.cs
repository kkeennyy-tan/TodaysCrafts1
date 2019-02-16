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
    public partial class FrmUserDashboard : Form
    {
        public FrmUserDashboard(string status)
        {
            InitializeComponent();
            lblstatus.Text = status;
        }

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
