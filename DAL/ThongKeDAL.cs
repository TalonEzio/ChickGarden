using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class ThongKeDAL
    {
        private static ThongKeDAL instance;
        public static ThongKeDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAL();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable ThongKeDoanhThuTheoNhomDoAnThangNay()
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeDoanhThuTheoNhomDoAn", DTO.CachThucHien.StoredProcedure);
        }
        public DataTable ThongKeDoanhThuNamNay()
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeDoanhThuNamNay", DTO.CachThucHien.StoredProcedure);
        }
        public DataTable ThongKeChiTieuNamNay()
        {
            return DatabaseAccess.Instance.ExecuteReader("usp_ThongKeChiTieuNamNay", DTO.CachThucHien.StoredProcedure);

        }
    }
}
