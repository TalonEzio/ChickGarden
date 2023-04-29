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
        public DataTable ThongKeDoanhThuTheoNhomDoAnThangNay()
        {
            return ThongKeDAL.Instance.ThongKeDoanhThuTheoNhomDoAnThangNay();
        }
        public DataTable ThongKeDoanhThuNamNay()
        {
            return ThongKeDAL.Instance.ThongKeDoanhThuNamNay();
        }
        public DataTable ThongKeChiTieuNamNay()
        {
            return ThongKeDAL.Instance.ThongKeChiTieuNamNay();

        }
    }
}
