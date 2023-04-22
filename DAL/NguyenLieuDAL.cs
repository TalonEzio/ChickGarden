using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguyenLieuDAL
    {
        private static NguyenLieuDAL instance;
        public static NguyenLieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NguyenLieuDAL();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable LayNguyenLieu(int maLNL = 0)
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_LayNguyenLieu", CachThucHien.StoredProcedure
               , new string[] { "@MaLNL" }, new object[] { maLNL });
        }
        public TrangThai XoaNguyenLieu(int maNL)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_XoaNguyenLieu",
                CachThucHien.StoredProcedure,
                new string[] { "@MaNL" },
                new object[] { maNL }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public TrangThai ThemNguyenLieu(NguyenLieu nguyenLieu, int maLNL)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_ThemNguyenLieu",
                CachThucHien.StoredProcedure,
                new string[] { "@TenNguyenLieu", "@SoLuong", "@DonViTinh", "@MaLNL" },
                new object[] { nguyenLieu.TenNguyenLieu, nguyenLieu.SoLuongTon, nguyenLieu.DonViTinh, maLNL }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
        public TrangThai CapNhatNguyenLieu(NguyenLieu nguyenLieu, int maLNL)
        {
            if (DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_CapNhatNguyenLieu",
                CachThucHien.StoredProcedure,
                new string[] { "@TenNguyenLieu", "@SoLuong", "@DonViTinh", "@MaLNL", "@MaNL" },
                new object[] { nguyenLieu.TenNguyenLieu, nguyenLieu.SoLuongTon, nguyenLieu.DonViTinh, maLNL, nguyenLieu.MaNguyenLieu }
                ) == 0
            )
                return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }
    }
}
