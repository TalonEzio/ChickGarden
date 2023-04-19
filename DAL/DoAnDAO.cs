using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoAnDAO
    {
        private static DoAnDAO instance;
        public static DoAnDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoAnDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<LoaiDoAn> LayDanhSachLoaiDoAn(int? maLDA = 0)
        {
            List<LoaiDoAn> DSLoaiDoAn = new List<LoaiDoAn>();
            DataTable dataTable = DatabaseAccess.Instance.ExecuteReader("usp_LayDanhSachLoaiDoAn", CachThucHien.StoredProcedure, new string[] { "@MaLDA" }, new object[] { maLDA });

            foreach (DataRow row in dataTable.Rows)
            {
                DSLoaiDoAn.Add(new LoaiDoAn()
                {
                    MaLDA = (int)row.ItemArray[0],
                    TenLDA = row.ItemArray[1].ToString(),
                });
            }
            return DSLoaiDoAn;
        }

    }
}
