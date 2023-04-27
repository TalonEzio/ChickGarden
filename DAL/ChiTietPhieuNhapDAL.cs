using DTO;
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
        public TrangThai ThemNguyenLieuVaoCTPN(object[] input)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery("usp_ThemNguyenLieuVaoCTPN", CachThucHien.StoredProcedure,
                new string[] { "@MaPhieuNhap", "@MaNguyenLieu", "@DonGia", "@SoLuong", "@HanSuDung" },
                input)
                > 0)
                return TrangThai.ThanhCong;
            return TrangThai.ThatBai;

        }
        public TrangThai CapNhatNguyenLieuTrongCTPN(object[] input)
        {
            if ((int)DatabaseAccess.Instance.ExecuteNonQuery("usp_CapNhatNguyenLieuTrongCTPN", CachThucHien.StoredProcedure,
                new string[] { "@MaPhieuNhap", "@MaNguyenLieu", "@DonGia", "@SoLuong", "@HanSuDung" },
                input)
                > 0)
                return TrangThai.ThanhCong;
            return TrangThai.ThatBai;

        }
        public TrangThai XoaNguyenLieuKhoiCTPN(int maPhieuNhap, int maNguyenLieu)
        {
            if ((int)DatabaseAccess.Instance.ExecuteNonQuery("usp_XoaNguyenLieuKhoiCTPN", CachThucHien.StoredProcedure,
                new string[] { "@MaPhieuNhap", "@MaNguyenLieu" },
                new object[] { maPhieuNhap, maNguyenLieu })
                > 0)
                return TrangThai.ThanhCong;
            return TrangThai.ThatBai;

        }
    }
}
