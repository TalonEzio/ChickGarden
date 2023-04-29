using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        private static PhieuNhapBLL instance;
        public static PhieuNhapBLL Instance
        {
            get
            {
                if (instance == null) instance = new PhieuNhapBLL();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable LayDanhSachPhieuNhap()
        {
            return PhieuNhapDAL.Instance.LayDanhSachPhieuNhap();
        }
        public TrangThai CapNhatPhieuNhap(PhieuNhap phieuNhap)
        {
            return PhieuNhapDAL.Instance.CapNhatPhieuNhap(phieuNhap);
        }
        public TrangThai ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            return PhieuNhapDAL.Instance.ThemPhieuNhap(phieuNhap);
        }
        public System.Data.DataTable PhieuNhapNguyenLieu(int maPhieuNhap)
        {
            return PhieuNhapDAL.Instance.PhieuNhapNguyenLieu(maPhieuNhap);
        }
    }
}
