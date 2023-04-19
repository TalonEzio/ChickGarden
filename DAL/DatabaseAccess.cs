using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class DatabaseAccess
    {
        string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ToString();

        public SqlConnection conn = null;

        private static DatabaseAccess instance;
        public static DatabaseAccess Instance
        {
            get
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
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }

            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    throw new Exception("Lỗi kết nối csdl");
                }
            }
        }
        public void DongKetNoi()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        static string BuildConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".\\SQLEXPRESS";
            builder.InitialCatalog = "ChickGarden";
            builder.IntegratedSecurity = true;

            return builder.ToString();
        }

        public int ExecuteNonQuery(string commandText, CachThucHien cachThucHien = CachThucHien.Query, string[] parameterName = null, object[] parameterValue = null)
        {
            if (parameterName == null) parameterName = new string[0];
            if (parameterValue == null) parameterValue = new object[0];
            MoKetNoi();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandType = cachThucHien == CachThucHien.Query ? CommandType.Text : CommandType.StoredProcedure,
                CommandText = commandText
            };

            if (parameterName.Length != parameterValue.Length)
            {
                throw new ArgumentException("Hai dau vao phai cung do dai");
            }
            for (int i = 0; i < parameterName.Length; ++i)
            {
                cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }
            int result = cmd.ExecuteNonQuery();
            DongKetNoi();
            return result;
        }
        public DataTable ExecuteReader(string commandText, CachThucHien cachThucHien = CachThucHien.Query, string[] parameterName = null, object[] parameterValue = null)
        {
            if (parameterName == null) parameterName = new string[0];
            if (parameterValue == null) parameterValue = new object[0];

            DataTable dataTable = new DataTable();

            MoKetNoi();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandType = cachThucHien == CachThucHien.Query ? CommandType.Text : CommandType.StoredProcedure,
                CommandText = commandText
            };

            if (parameterName.Length != parameterValue.Length)
            {
                throw new ArgumentException("Hai dau vao phai cung do dai");
            }

            for (int i = 0; i < parameterName.Length; ++i)
            {
                cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }

            dataTable.Load(cmd.ExecuteReader());

            DongKetNoi();


            return dataTable;
        }

        public object ExecuteScalar(string commandText, CachThucHien cachThucHien = CachThucHien.Query, string[] parameterName = null, object[] parameterValue = null)
        {
            if (parameterName == null) parameterName = new string[0];
            if (parameterValue == null) parameterValue = new object[0];

            MoKetNoi();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandType = cachThucHien == CachThucHien.Query ? CommandType.Text : CommandType.StoredProcedure,
                CommandText = commandText
            };

            if (parameterName.Length != parameterValue.Length)
            {
                throw new ArgumentException("Hai dau vao phai cung do dai");
            }
            for (int i = 0; i < parameterName.Length; ++i)
            {
                cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
            }
            object result = cmd.ExecuteScalar();
            DongKetNoi();

            return result;
        }
    }

}
