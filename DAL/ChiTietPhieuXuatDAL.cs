using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuXuatDAL
    {
        private static ChiTietPhieuXuatDAL instance;
        public static ChiTietPhieuXuatDAL Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietPhieuXuatDAL(); return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable LayChiTietPhieuXuat(int maPhieuXuat)
        {
            return DatabaseAccess.Instance.ExecuteReader(
                    "usp_LayChiTietPhieuXuat", 
                    DTO.CachThucHien.StoredProcedure
                    ,new string[] { "@MaHoaDon" },
                    new object[] {maPhieuXuat} 
                 );
        }
        public TrangThai ThemDoAnVaoPhieuXuat(object[] input)
        {
            int result = DatabaseAccess.Instance.ExecuteNonQuery("usp_ThemDoAnVaoPhieuXuat", CachThucHien.StoredProcedure,
                new string[] { "@MaHoaDon", "@MaDoAn", "@SoLuong", "@DonGia" },
                input);
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }

        public TrangThai CapNhatDoAnTrongCTPX(object[] input)
        {
            int result = DatabaseAccess.Instance.ExecuteNonQuery("usp_CapNhatDoAnTrongCTPX", CachThucHien.StoredProcedure,
                new string[] { "@MaHoaDon", "@MaDoAn", "@SoLuong", "@DonGia" },
                input);
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public TrangThai XoaDoAnKhoiCTPX(object[] input)
        {
            int result = DatabaseAccess.Instance.ExecuteNonQuery("usp_XoaDoAnKhoiCTPX", CachThucHien.StoredProcedure,
                new string[] { "@MaHoaDon", "@MaDoAn" },
                input);
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
    }
}
