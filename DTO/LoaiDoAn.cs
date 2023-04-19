using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDoAn
    {
        public int? MaLDA { get; set; }
        public string TenLDA { get; set; }
        public override string ToString()
        {
            return TenLDA;
        }
    }
}
