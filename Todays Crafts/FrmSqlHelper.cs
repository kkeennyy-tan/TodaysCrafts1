using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Todays_Crafts
{
    public class FrmSqlHelper
    {
        SqlConnection con;
        public FrmSqlHelper(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }
    public bool IsConnection
        {
            get
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return true;
            }
        }
    }
}
