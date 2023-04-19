using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVuBLL
    {
        private static ChucVuBLL instance;

        public static ChucVuBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuBLL();
                }
                return instance;
            }
            set { instance = value; }
        }

        public List<ChucVu> LayChucVu()
        {
            return ChucVuDAO.Instance.LayChucVu();
        }
    }
}
