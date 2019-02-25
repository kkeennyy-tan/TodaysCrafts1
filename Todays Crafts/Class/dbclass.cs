using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Todays_Crafts.Class
{
    class dbclass
    {
        public SqlConnection conDB; // call connection

        public dbclass()
        {

            string con = @"Data Source=KENNY\SERVER;Initial Catalog=TodaysCrafts;Integrated Security=True";
            conDB = new SqlConnection(con); //connection string
        }
       // public string constring = @"Data Source=CISCO-27\SQLEXPRESS;Initial Catalog=TodaysCrafts;Integrated Security=True";
    }
}
