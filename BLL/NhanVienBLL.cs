using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public TrangThai CapNhatThongTin(NhanVien nhanVien,int maChucVu,string username)
        {
            return NhanVienDAO.Instance.CapNhatThongTin(nhanVien, maChucVu, username);
        }
        public DataTable LayDanhSach(string username)
        {
            return NhanVienDAO.Instance.LayDanhSach(username);
        }

    }
}
