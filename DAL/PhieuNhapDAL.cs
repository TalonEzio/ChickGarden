using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        private static PhieuNhapDAL instance;
        public static PhieuNhapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapDAL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable LayDanhSachPhieuNhap()
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_LayPhieuNhap", DTO.CachThucHien.StoredProcedure);
        }
        public TrangThai CapNhatPhieuNhap(PhieuNhap phieuNhap)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_CapNhatPhieuNhap", CachThucHien.StoredProcedure,
                new string[] { "@NgayNhap", "@MaNCC", "@MaNV", "@MoTa", "@MaPhieuNhap" },
                new object[] { phieuNhap.NgayNhap, phieuNhap.MaNCC, phieuNhap.MaNV, phieuNhap.MoTa, phieuNhap.MaPhieuNhap }
                ) == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
    }
}
