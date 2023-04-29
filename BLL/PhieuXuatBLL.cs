using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class PhieuXuatBLL
    {
        private static PhieuXuatBLL instance;
        public static PhieuXuatBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuXuatBLL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable LayDanhSachPhieuXuat()
        {
            return PhieuXuatDAL.Instance.LayDanhSachPhieuXuat();
        }
        public TrangThai ThemPhieuXuat(PhieuXuat phieuXuat)
        {
            return PhieuXuatDAL.Instance.ThemPhieuXuat(phieuXuat);
        }
        public TrangThai CapNhatPhieuXuat(PhieuXuat phieuXuat)
        {
            return PhieuXuatDAL.Instance.CapNhatPhieuXuat(phieuXuat);
        }
        public DataTable PhieuXuatDoAn(int maPhieuXuat)
        {
            return PhieuXuatDAL.Instance.PhieuXuatDoAn(maPhieuXuat);
        }

    }
}
