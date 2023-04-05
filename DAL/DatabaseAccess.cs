using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DatabaseAccess
    {
        private string strConn = BuildConnectionString();

        public SqlConnection conn = null;

        private static DatabaseAccess instance;
        public static DatabaseAccess Instance
        { get
            {
                if (instance == null)
                {
                    instance = new DatabaseAccess();
                }
                return instance;
            }
            private set { instance = value; }
        }

        public void MoKetNoi()
        {
            if(conn == null)
            {
                conn = new SqlConnection(strConn);
            }

            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi kết nối csdl");
                }
            }
        }
        public void DongKetNoi() 
        {
            if(conn != null && conn.State == System.Data.ConnectionState.Open) 
            {
                conn.Close();
            }
        }

        static string BuildConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "TALONEZIO\\SQLEXPRESS";
            builder.InitialCatalog = "ChickGarden";
            builder.UserID = "sa";
            builder.Password = "manhngu123";

            return builder.ToString();
        }
    }

}
