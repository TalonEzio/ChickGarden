using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        private static ThongKeBLL instance;
        public static ThongKeBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeBLL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable ThongKeDoanhThuTheoNhomDoAn(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return ThongKeDAL.Instance.ThongKeDoanhThuTheoNhomDoAn(ngayBatDau, ngayKetThuc);
        }
        public DataTable ThongKeDoanhThuTheoNam(int nam)
        {
            return ThongKeDAL.Instance.ThongKeDoanhThuTheoNam(nam);
        }
        public DataTable ThongKeChiTieuTheoNam(int nam)
        {
            return ThongKeDAL.Instance.ThongKeChiTieuTheoNam(nam);

        }
    }
}
