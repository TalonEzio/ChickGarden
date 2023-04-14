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
    public partial class ucThongTinCaNhan : UserControl
    {
        public ucThongTinCaNhan()
        {
            InitializeComponent();
        }
        private TaiKhoan taiKhoan;
        public ucThongTinCaNhan(TaiKhoan taiKhoan)
        {
            InitializeComponent();
        }

    }
}
