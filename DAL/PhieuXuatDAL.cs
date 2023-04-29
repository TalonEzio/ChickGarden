using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuXuatDAL
    {
        private static PhieuXuatDAL instance;
        public static PhieuXuatDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuXuatDAL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable LayDanhSachPhieuXuat()
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_LayPhieuXuat", DTO.CachThucHien.StoredProcedure);
        }
        public TrangThai ThemPhieuXuat(PhieuXuat phieuXuat)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery("usp_ThemPhieuXuat", CachThucHien.StoredProcedure,
                new string[] { "@NgayBan", "@MaNV", "@MoTa", "@TenKhachHang" },
                new object[] { phieuXuat.NgayBan, phieuXuat.MaNV, phieuXuat.MoTa, phieuXuat.TenKhachHang }
                ) > 0)
                return TrangThai.ThanhCong;
            return TrangThai.ThatBai;
        }

        public TrangThai CapNhatPhieuXuat(PhieuXuat phieuXuat)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery("usp_CapNhatPhieuXuat", CachThucHien.StoredProcedure,
                new string[] { "@NgayBan", "@MaNV", "@MoTa", "@TenKhachHang", "@MaHoaDon" },
                new object[] { phieuXuat.NgayBan, phieuXuat.MaNV, phieuXuat.MoTa, phieuXuat.TenKhachHang, phieuXuat.MaPhieuXuat }
                ) > 0)
                return TrangThai.ThanhCong;
            return TrangThai.ThatBai;
        }

    }
}
