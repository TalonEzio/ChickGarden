using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiNguyenLieuBLL
    {
        private static LoaiNguyenLieuBLL instance;

        public static LoaiNguyenLieuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiNguyenLieuBLL();
                }
                return instance;
            }
            set { instance = value; }
        }
        public List<LoaiNguyenLieu> LayLoaiNguyenLieu(int maLNL = 0)
        {
            return LoaiNguyenLieuDAL.Instance.LayLoaiNguyenLieu(maLNL);
        }

    }
}
