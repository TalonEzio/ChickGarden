using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        private static ThongKeDAL instance;
        public static ThongKeDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable ThongKeDoanhThuTheoNhomDoAn(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeDoanhThuTheoNhomDoAn", DTO.CachThucHien.StoredProcedure,
                new string[] { "@NgayBatDau", "@NgayKetThuc" },
                new object[] { ngayBatDau, ngayKetThuc });
        }
        public DataTable ThongKeDoanhThuTheoNam(int nam)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeDoanhThuTheoNam", DTO.CachThucHien.StoredProcedure,
                new string[] { "@Nam" }, new object[] { nam });
        }
        public DataTable ThongKeChiTieuTheoNam(int nam)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeChiTieuTheoNam",
                DTO.CachThucHien.StoredProcedure,
                 new string[] { "@Nam" }, new object[] { nam });

        }
    }
}
