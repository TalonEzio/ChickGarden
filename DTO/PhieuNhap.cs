﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public DateTimeOffset NgayNhap { get; set; }
        public int MaNV { get; set; }
        public int MaNCC { get; set; }
        public string MoTa { get; set; }
    }
}
