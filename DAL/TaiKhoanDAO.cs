using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using DTO ;
using BC = BCrypt.Net.BCrypt;
namespace DAL
{
    public class TaiKhoanDAO
    {
		private static TaiKhoanDAO instance;

		public static TaiKhoanDAO Instance
		{
			get { 
				if(instance == null)
				{
					instance = new TaiKhoanDAO();
				}
				return instance;
			}
			set { instance = value; }
		}
		public TrangThai DangNhap(string username, string password)
		{
			DatabaseAccess.Instance.MoKetNoi();

			SqlCommand cmd = new SqlCommand()
			{
				CommandType = System.Data.CommandType.StoredProcedure,
				CommandText = "usp_LayMatKhau",
				Connection = DatabaseAccess.Instance.conn
            };
			cmd.Parameters.AddWithValue("@Username", username);

			string hashPassword;
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				if (!reader.HasRows) return TrangThai.ThatBai;

				reader.Read();
				hashPassword = reader.GetString(0);

			}

            DatabaseAccess.Instance.DongKetNoi();

			if (BC.Verify(password, hashPassword))
			{
				return TrangThai.ThanhCong;
			}
			return TrangThai.ThatBai;
		}
		public TrangThai KiemTraTaiKhoan(string username) {
			DatabaseAccess.Instance.MoKetNoi();
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "usp_LayMatKhau",
                Connection = DatabaseAccess.Instance.conn
            };
            cmd.Parameters.AddWithValue("@Username", username);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows) return TrangThai.UserDaTonTai;

            }

            DatabaseAccess.Instance.DongKetNoi();

            return TrangThai.ThanhCong;
        }
        public TrangThai DangKy(TaiKhoan taiKhoan,ChucVu chucVu)
		{
            DatabaseAccess.Instance.MoKetNoi();

            SqlCommand cmd = new SqlCommand()
			{
				CommandType = System.Data.CommandType.StoredProcedure,
				CommandText = "usp_DangKy",
				Connection = DatabaseAccess.Instance.conn
			};
			cmd.Parameters.AddWithValue("@Username", taiKhoan.Username);
			cmd.Parameters.AddWithValue("@Password",BC.HashPassword(taiKhoan.Password));
			cmd.Parameters.AddWithValue("@RawPassword", taiKhoan.Password);
			cmd.Parameters.AddWithValue("@Ho", taiKhoan.Ho);
			cmd.Parameters.AddWithValue("@Ten",taiKhoan.Ten);
			cmd.Parameters.AddWithValue("@NgaySinh", taiKhoan.NgaySinh);
			cmd.Parameters.AddWithValue("@GioiTinh", taiKhoan.GioiTinh);
			cmd.Parameters.AddWithValue("@QueQuan", taiKhoan.QueQuan);
			cmd.Parameters.AddWithValue("@SoDienThoai",taiKhoan.SoDienThoai);
			cmd.Parameters.AddWithValue("@MaChucVu", chucVu.MaChucVu);
			try
			{
				cmd.ExecuteNonQuery();
                DatabaseAccess.Instance.DongKetNoi();
                return TrangThai.ThanhCong;
            }
			catch (Exception ex)
			{
                return TrangThai.ThatBai;
            }
			finally
			{
                DatabaseAccess.Instance.DongKetNoi();

            }


        }


    }
}
