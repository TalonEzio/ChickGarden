using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using DTO;
using BC = BCrypt.Net.BCrypt;
namespace DAL
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
            set { instance = value; }
        }
        public TrangThai DangNhap(TaiKhoan taiKhoan)
        {
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayMatKhau", CachThucHien.StoredProcedure,
                new string[] { "@Username" },
                new object[] { taiKhoan.Username });

            if (dt.Rows.Count == 0) return TrangThai.ThatBai;
            string hashPassword = dt.Rows[0].ItemArray[0].ToString();

            if (BC.Verify(taiKhoan.Password, hashPassword))
            {
                return TrangThai.ThanhCong;
            }
            return TrangThai.ThatBai;
        }
        public void LayQuyen(TaiKhoan taiKhoan)
        {
            taiKhoan.isAdmin = (int)DatabaseAccess.Instance.ExecuteScalar("usp_LayQuyen", CachThucHien.StoredProcedure,
                new string[] { "@Username" }
                , new string[] { taiKhoan.Username }
                ) == 1;
        }
        private TrangThai KiemTraTaiKhoan(string username)
        {
            DataTable dt = DatabaseAccess.Instance.ExecuteReader(
                    "usp_LayMatKhau",
                    CachThucHien.StoredProcedure,
                    new string[] { "@Username" },
                    new object[] { username }
                );

            if (dt.Rows.Count == 0) return TrangThai.ThatBai;

            return TrangThai.UserDaTonTai;
        }
        public TrangThai DangKy(TaiKhoan taiKhoan, NhanVien nhanVien, ChucVu chucVu)
        {

            TrangThai trangThai = KiemTraTaiKhoan(taiKhoan.Username);
            if (trangThai == TrangThai.UserDaTonTai) return trangThai;

            int result = DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_DangKy",
                CachThucHien.StoredProcedure,
                new string[] {
                    "@Username", "@Password", "@RawPassword", "@MaChucVu",
                    "@HoTen","@NgaySinh","@GioiTinh",
                    "@QueQuan","@SoDienThoai" },
                new object[] {
                    taiKhoan.Username,BC.HashPassword(taiKhoan.Password),
                    taiKhoan.Password,chucVu.MaChucVu,
                    nhanVien.HoTen,nhanVien.NgaySinh,nhanVien.GioiTinh,
                    nhanVien.QueQuan,nhanVien.SoDienThoai

                });
            trangThai = (result == 0) ? TrangThai.ThatBai : TrangThai.ThanhCong;
            return trangThai;
        }

        public TrangThai DoiMatKhau(TaiKhoan taiKhoan, string newPassword)
        {
            string hashPassword = BC.HashPassword(newPassword);
            int result = DatabaseAccess.Instance.ExecuteNonQuery(
                "usp_DoiMatKhau", CachThucHien.StoredProcedure,
                new string[] { "@Username", "@Password", "@RawPassword" },
                new string[] { taiKhoan.Username, hashPassword, newPassword }
                );
            if (result == 0) return TrangThai.ThatBai;
            return TrangThai.ThanhCong;
        }

    }
}
