﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public override string ToString()
        {
            return TenChucVu;
        }
    }
}
