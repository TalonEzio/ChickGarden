using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            return NhanVienDAL.Instance.LayThongTinNhanVien(username);
        }
        public TrangThai CapNhatThongTin(NhanVien nhanVien, int maChucVu, string username)
        {
            return NhanVienDAL.Instance.CapNhatThongTin(nhanVien, maChucVu, username);
        }
        public DataTable LayDanhSachNgoaiTru(string username)
        {
            return NhanVienDAL.Instance.LayDanhSachNgoaiTru(username);
        }
        public List<NhanVien> LayTatCaNhanVien()
        {
            return NhanVienDAL.Instance.LayTatCaNhanVien();
        }
        public int LayMaNhanVien(string userName)
        {
            return NhanVienDAL.Instance.LayMaNhanVien(userName);
        }
    }
}
