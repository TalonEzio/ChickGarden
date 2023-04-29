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
        public TrangThai ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_ThemPhieuNhap", CachThucHien.StoredProcedure,
                new string[] { "@NgayNhap", "@MaNCC", "@MaNV", "@MoTa" },
                new object[] { phieuNhap.NgayNhap, phieuNhap.MaNCC, phieuNhap.MaNV, phieuNhap.MoTa }
                ) == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public System.Data.DataTable PhieuNhapNguyenLieu(int maPhieuNhap)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_PhieuNhapNguyenLieu", CachThucHien.StoredProcedure,
                new string[] { "@maPhieuNhap" }, new object[] { maPhieuNhap });
        }
    }
}
