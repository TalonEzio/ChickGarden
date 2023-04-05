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

			//Test
			//if(inputPassword == password)
			//{
			//	return TrangThai.ThanhCong;
			//}
			//return TrangThai.ThatBai;
		}

	}
}
