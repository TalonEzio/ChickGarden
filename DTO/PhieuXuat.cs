using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat
    {
        public int MaPhieuXuat { get; set; }
        public DateTimeOffset NgayBan { get; set; }
        public int MaNV { get; set; }
        public string TenKhachHang { get; set; }
        public string MoTa { get; set; }
    }
}
