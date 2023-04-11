﻿using DTO;
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

		public TrangThai DangNhap(string username, string password)
		{
			return TaiKhoanDAO.Instance.DangNhap(username, password);
		}
		public TrangThai DangKy(TaiKhoan taiKhoan,ChucVu chucVu)
		{


			return TaiKhoanDAO.Instance.DangKy(taiKhoan,chucVu);
		}
	}
}
