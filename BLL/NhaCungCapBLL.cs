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
    public class NhaCungCapBLL
    {
        private static NhaCungCapBLL instance;

        public static NhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBLL();
                }
                return instance;
            }
            set { instance = value; }
        }
        public List<NhaCungCap> LayToanBoNhaCungCap()
        {
            return NhaCungCapDAL.Instance.LayToanBoNhaCungCap();
        }
        public NhaCungCap LayNhaCungCapTheoMa(int maNCC)
        {
            return NhaCungCapDAL.Instance.LayNhaCungCapTheoMa(maNCC);
        }
        public System.Data.DataTable PhieuNhapNguyenLieu(int maNCC)
        {
            return NhaCungCapDAL.Instance.PhieuNhapNguyenLieu(maNCC);
        }
    }
}
