using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BLL
{
	public class TaiKhoanBLL
	{
		private static TaiKhoanBLL instance;

		public static TaiKhoanBLL Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TaiKhoanBLL();
				}
				return instance;
			}
			set { instance = value; }
		}
		public TaiKhoanBLL() { }

		public TrangThai DangNhap(TaiKhoan taiKhoan)
		{
			return TaiKhoanDAO.Instance.DangNhap(taiKhoan);
		}
		public TrangThai DangKy(TaiKhoan taiKhoan,NhanVien nhanVien,ChucVu chucVu)
		{
			return TaiKhoanDAO.Instance.DangKy(taiKhoan,nhanVien, chucVu);
		}
		public TrangThai DoiMatKhau(TaiKhoan taiKhoan,string newPassword)
		{
			return TaiKhoanDAO.Instance.DoiMatKhau(taiKhoan, newPassword);
		}	
		public void LayQuyen(TaiKhoan taiKhoan)
		{
            TaiKhoanDAO.Instance.LayQuyen(taiKhoan);
        }
        public TrangThai XoaTaiKhoan(string username)
        {
            return TaiKhoanDAO.Instance.XoaTaiKhoan(username);
        }
		public void LayId(TaiKhoan taiKhoan)
		{
			TaiKhoanDAO.Instance.LayId(taiKhoan);
		}
    }
}
