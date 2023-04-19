using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoAnDAO
    {
        private static DoAnDAO instance;
        public static DoAnDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoAnDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<LoaiDoAn> LayDanhSachLoaiDoAn(int? maLDA = 0)
        {
            List<LoaiDoAn> DSLoaiDoAn = new List<LoaiDoAn>();
            DataTable dataTable = DatabaseAccess.Instance.ExecuteReader("usp_LayDanhSachLoaiDoAn", CachThucHien.StoredProcedure, new string[] { "@MaLDA" }, new object[] { maLDA });

            foreach (DataRow row in dataTable.Rows)
            {
                DSLoaiDoAn.Add(new LoaiDoAn()
                {
                    MaLDA = (int)row.ItemArray[0],
                    TenLDA = row.ItemArray[1].ToString(),
                });
            }
            return DSLoaiDoAn;
        }
        public DataTable LayDoAn(int? maLDA = 0)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_LayDoAn", CachThucHien.StoredProcedure, new string[] { "@MaLDA" }, new object[] { maLDA });
        }
        public TrangThai ThemDoAn(string tenDoAn, int MaLDA)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_ThemDoAn",
                CachThucHien.StoredProcedure,
                new string[] { "@TenDoAn", "@MaLDA" },
                new object[] { tenDoAn, MaLDA }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public TrangThai XoaDoAn(int MaDoAn)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_XoaDoAn",
                CachThucHien.StoredProcedure,
                new string[] { "@MaDoAn" },
                new object[] { MaDoAn }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public TrangThai CapNhatDoAn(int maDoAn, string tenDoAn, int maLDA)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_CapNhatDoAn",
                CachThucHien.StoredProcedure,
                new string[] { "@MaDoAn","@TenDoAn", "@MaLDA"  },
                new object[] { maDoAn,tenDoAn,maLDA }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
    }
}
