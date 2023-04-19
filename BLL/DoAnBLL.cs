using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DoAnBLL
    {
        private static DoAnBLL instance;
        public static DoAnBLL Instance
        {
            get
            {
                if (instance == null) instance = new DoAnBLL();
                return instance;
            }
            set { instance = value; }
        }

        public List<LoaiDoAn> LayDanhSachLoaiDoAn(int? maLDA = 0)
        {
            return DoAnDAO.Instance.LayDanhSachLoaiDoAn(maLDA);
        }
        public DataTable LayDoAn(int? maLDA = 0)
        {
            return DoAnDAO.Instance.LayDoAn(maLDA);
        }
    }
}
