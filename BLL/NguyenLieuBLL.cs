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
    public class NguyenLieuBLL
    {
        private static NguyenLieuBLL instance;
        public static NguyenLieuBLL Instance
        {
            get
            {
                if (instance == null) instance = new NguyenLieuBLL();
                return instance;
            }
            set
            { instance = value; }
        }
        public DataTable LayNguyenLieu(int maLNL = 0)
        {
            return NguyenLieuDAL.Instance.LayNguyenLieu(maLNL);
        }
        public TrangThai XoaNguyenLieu(int maNL)
        {
            return NguyenLieuDAL.Instance.XoaNguyenLieu(maNL);
        }
        public TrangThai ThemNguyenLieu(NguyenLieu nguyenLieu, int maLNL)
        {
            return NguyenLieuDAL.Instance.ThemNguyenLieu(nguyenLieu,maLNL);
        }
      public TrangThai CapNhatNguyenLieu(NguyenLieu nguyenLieu, int maLNL)
        {
            return NguyenLieuDAL.Instance.CapNhatNguyenLieu(nguyenLieu, maLNL);
        }


    }
}
