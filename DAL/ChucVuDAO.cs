using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayChucVu",CachThucHien.StoredProcedure);
            List<ChucVu> DSCV = new List<ChucVu> ();
            foreach (DataRow dr in dt.Rows)
            {
                DSCV.Add(new ChucVu
                { MaChucVu = int.Parse(dr.ItemArray[0].ToString()), TenChucVu = dr.ItemArray[1].ToString() });
            }

            return DSCV;
        }
    }
}
