using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new ChucVuDAO();
                }
                return instance;
            } private set
            {
                instance = value;
            }
        }
        public List<ChucVu> LayChucVu()
        {
            DatabaseAccess.Instance.MoKetNoi();
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "usp_LayChucVu",
                Connection = DatabaseAccess.Instance.conn
            };
            cmd.Parameters.Clear();
            List<ChucVu> DSCV = new List<ChucVu> ();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read ())
                {
                    ChucVu cv = new ChucVu ();
                    cv.MaChucVu = reader.GetInt32(0);
                    cv.TenChucVu = reader.GetString(1);

                    DSCV.Add(cv);
                }
            }
            DatabaseAccess.Instance.DongKetNoi();

            return DSCV;
        }
    }
}
