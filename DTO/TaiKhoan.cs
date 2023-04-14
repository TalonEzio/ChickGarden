using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public int TaiKhoanId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
    }
}
