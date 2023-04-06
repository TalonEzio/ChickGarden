using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public int GioiTinh { get; set; }
    }
}
