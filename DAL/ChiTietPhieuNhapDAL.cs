using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        private static ChiTietPhieuNhapDAL instance;
        public static ChiTietPhieuNhapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable LayChiTietPhieuNhap(int maPhieuNhap)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_LayChiTietPhieuNhap", DTO.CachThucHien.StoredProcedure,
                new string[] { "@MaPhieuNhap" },
                new object[] { maPhieuNhap });
        }
    }
}
