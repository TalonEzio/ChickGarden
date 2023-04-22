﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucPhieuNhap : UserControl
    {
        TaiKhoan taiKhoan;
        NhanVien nhanVien;
        public ucPhieuNhap(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.Username);
        }

    }
}