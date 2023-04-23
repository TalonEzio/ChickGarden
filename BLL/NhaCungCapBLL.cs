using DAL;
using DTO;
using System;
using System.Collections.Generic;
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

    }
}
