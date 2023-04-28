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
    public class ChiTietPhieuXuatBLL
    {
        private static ChiTietPhieuXuatBLL instance;
        public static ChiTietPhieuXuatBLL Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietPhieuXuatBLL();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable LayChiTietPhieuXuat(int maPhieuXuat)
        {
            return ChiTietPhieuXuatDAL.Instance.LayChiTietPhieuXuat(maPhieuXuat);
        }
        public TrangThai ThemDoAnVaoPhieuXuat(object[] input)
        {
            return ChiTietPhieuXuatDAL.Instance.ThemDoAnVaoPhieuXuat(input);

        }

        public TrangThai CapNhatDoAnTrongCTPX(object[] input)
        {
            return ChiTietPhieuXuatDAL.Instance.CapNhatDoAnTrongCTPX(input);

        }
        public TrangThai XoaDoAnKhoiCTPX(int maPhieuXuat,int madoAn)
        {
            return ChiTietPhieuXuatDAL.Instance.XoaDoAnKhoiCTPX(maPhieuXuat,madoAn);

        }
    }
}
