using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNguyenLieu
    {
        public int MaLNL { get;set; }
        public string TenLNL { get;set; }
        public override string ToString()
        {
            return TenLNL;
        }
    }
}
