using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private static NhaCungCapDAL instance;
        public static NhaCungCapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAL();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<NhaCungCap> LayToanBoNhaCungCap()
        {
            List<NhaCungCap> DSNCC = new List<NhaCungCap>();
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayTatCaNhaCungCap", CachThucHien.StoredProcedure);
            foreach (DataRow dr in dt.Rows)
            {
                DSNCC.Add(new NhaCungCap()
                {
                    MaNCC = (int)dr.ItemArray[0],
                    TenNCC = dr.ItemArray[1].ToString(),
                    DiaChi = dr.ItemArray[2].ToString(),
                    SoDienThoai = dr.ItemArray[3].ToString()
                });
            }
            return DSNCC;
        }
        public NhaCungCap LayNhaCungCapTheoMa(int maNCC)
        {
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayNhaCungCapTheoMa", CachThucHien.StoredProcedure
                , new string[] { "@MaNCC" }, new object[] { maNCC });
            if(dt != null)
            {
                DataRow dr = dt.Rows[0];
                return new NhaCungCap()
                {
                    MaNCC = (int)dr[0],
                    TenNCC = dr[1].ToString(),
                    DiaChi = dr[2].ToString(),
                    SoDienThoai = dr[3].ToString()
                };
            }
            return null;
        }
        public System.Data.DataTable PhieuNhapNguyenLieu(int maNCC)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_PhieuNhapNguyenLieu", CachThucHien.StoredProcedure,
                new string[] { "@MaNCC" }, new object[] { maNCC });
        }
    }
}
