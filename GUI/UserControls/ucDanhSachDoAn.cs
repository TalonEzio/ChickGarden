using BLL;
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
        List<LoaiDoAn> DSLoaiDoAn = new List<LoaiDoAn>()
        { 
            new LoaiDoAn(){MaLDA = 0,TenLDA = "Tất cả"}
        };
        void TaiLoaiDoAn(ComboBox comboBox)
        {
            DSLoaiDoAn.AddRange(DoAnBLL.Instance.LayDanhSachLoaiDoAn());
            comboBox.Items.Clear();
            comboBox.DataSource = DSLoaiDoAn;
            comboBox.DisplayMember = "TenLDA";
            comboBox.ValueMember = "MaLDA";

        }
        private void ucDanhSachDoAn_Load(object sender, EventArgs e)
        {
            TaiLoaiDoAn(cmbLoaiDoAn);
        }

        private void cmbLoaiDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLoaiDoAn.SelectedItem == null)
            {

            }
        }
    }
}
