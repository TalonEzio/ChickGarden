using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
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
			return TaiKhoanDAL.Instance.DangNhap(taiKhoan);
		}
		public TrangThai DangKy(TaiKhoan taiKhoan,NhanVien nhanVien,ChucVu chucVu)
		{
			return TaiKhoanDAL.Instance.DangKy(taiKhoan,nhanVien, chucVu);
		}
		public TrangThai DoiMatKhau(TaiKhoan taiKhoan,string newPassword)
		{
			return TaiKhoanDAL.Instance.DoiMatKhau(taiKhoan, newPassword);
		}	
		public void LayQuyen(TaiKhoan taiKhoan)
		{
            TaiKhoanDAL.Instance.LayQuyen(taiKhoan);
        }
        public TrangThai XoaTaiKhoan(string username)
        {
            return TaiKhoanDAL.Instance.XoaTaiKhoan(username);
        }
		public void LayId(TaiKhoan taiKhoan)
		{
			TaiKhoanDAL.Instance.LayId(taiKhoan);
		}
    }
}
