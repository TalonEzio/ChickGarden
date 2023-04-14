using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBLL();
                }
                return instance;
            }
            set { instance = value; }
        }
        public NhanVien LayThongTinNhanVien(string username)
        {
            return NhanVienDAO.Instance.LayThongTinNhanVien(username);
        }
        public TrangThai CapNhatThongTin(NhanVien nhanVien,string username)
        {
            return NhanVienDAO.Instance.CapNhatThongTin(nhanVien,username);
        }

    }
}
