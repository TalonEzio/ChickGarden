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
    public class ChiTietPhieuNhapBLL
    {
        private static ChiTietPhieuNhapBLL instance;
        public static ChiTietPhieuNhapBLL Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietPhieuNhapBLL();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable LayDanhSachPhieuNhap(int maPhieuNhap)
        {
            return ChiTietPhieuNhapDAL.Instance.LayChiTietPhieuNhap(maPhieuNhap);
        }
        public TrangThai ThemNguyenLieuVaoCTPN(object[] input)
        {
            return ChiTietPhieuNhapDAL.Instance.ThemNguyenLieuVaoCTPN(input);
        }
        public TrangThai CapNhatNguyenLieuTrongCTPN(object[] input)
        {
            return ChiTietPhieuNhapDAL.Instance.CapNhatNguyenLieuTrongCTPN(input);

        }
        public TrangThai XoaNguyenLieuKhoiCTPN(int maPhieuNhap, int maNguyenLieu)
        {
            return ChiTietPhieuNhapDAL.Instance.XoaNguyenLieuKhoiCTPN(maPhieuNhap, maNguyenLieu);
        }


    }
}
