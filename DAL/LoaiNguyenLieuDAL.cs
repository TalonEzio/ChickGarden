using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiNguyenLieuDAL
    {
        private static LoaiNguyenLieuDAL instance;
        public static LoaiNguyenLieuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiNguyenLieuDAL();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<LoaiNguyenLieu> LayLoaiNguyenLieu(int maLNL = 0)
        {
            List<LoaiNguyenLieu> DSLoaiNguyenLieu = new List<LoaiNguyenLieu>();
            DataTable dt = DatabaseAccess.Instance.ExecuteReader("usp_LayLoaiNguyenLieu", CachThucHien.StoredProcedure
                , new string[] { "@MaLNL" }, new object[] { maLNL });
            foreach (DataRow dr in dt.Rows)
            {
                DSLoaiNguyenLieu.Add(new LoaiNguyenLieu()
                { MaLNL = (int)dr.ItemArray[0], TenLNL = dr.ItemArray[1].ToString() });
            }
            return DSLoaiNguyenLieu;
        }
    }
}
