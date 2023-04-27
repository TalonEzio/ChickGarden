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
            return DoAnDAL.Instance.LayDanhSachLoaiDoAn(maLDA);
        }
        public DataTable LayDoAn(int? maLDA = 0)
        {
            return DoAnDAL.Instance.LayDoAn(maLDA);
        }
        public TrangThai ThemDoAn(string tenDoAn, int MaLDA)
        {
            return DoAnDAL.Instance.ThemDoAn(tenDoAn, MaLDA);
        }
        public  TrangThai XoaDoAn(int MaDoAn)
        {
            return DoAnDAL.Instance.XoaDoAn(MaDoAn);

        }
        public TrangThai CapNhatDoAn(int maDoAn, string tenDoAn, int maLDA)
        {
            return DoAnDAL.Instance.CapNhatDoAn(maDoAn,tenDoAn,maLDA);
        }
        public List<DoAn> LayTatCaDoAn()
        {
            return DoAnDAL.Instance.LayTatCaDoAn();
        }
    }
}
