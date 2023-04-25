using DAL;
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

    }
}
