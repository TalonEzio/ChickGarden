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
    public partial class ucDanhSachDoAn : UserControl
    {
        private TaiKhoan taiKhoan;
        public ucDanhSachDoAn()
        {
            InitializeComponent();
        }
        public ucDanhSachDoAn(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }

        private void ucDanhSachDoAn_Load(object sender, EventArgs e)
        {
            cmbLoaiDoAn.EditValue = "HEHE";
        }
    }
}
