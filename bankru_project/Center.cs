using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bankru_project
{
    internal class Center
    {
        // Connect
        //Data Source=localhost;Initial Catalog=PTECPOS;User ID=Pong;Password=Pong555;Encrypt=False

        private static string GetConnectionString()
        {
            string constring = "Data Source=localhost;Initial Catalog=PTECPOS;User ID=Pong;Password=Pong555;Encrypt=False";
            return constring;
        }

        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static BindingSource bs;
        // SQL COMMAND (INSERT, UPDATE, DELETE)
        public static string sql;

        public static void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = GetConnectionString();
                con.Open();
            }
        }

        public static void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
