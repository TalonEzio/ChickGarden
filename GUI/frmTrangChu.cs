using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangChu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool forceExit = false;
        internal bool ForceExit
        {
            get
            {
                return forceExit;
            }
            set
            {
                forceExit = value;
            }
        }
        private TaiKhoan taiKhoan;
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public frmTrangChu(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceExit)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private ucDanhSachNhanVien ucDanhSachNhanVien = null;
        private void btnDSNV_Click(object sender, EventArgs e)
        {
            if (ucDanhSachNhanVien == null)
            {
                ucDanhSachNhanVien = new ucDanhSachNhanVien();
                ucDanhSachNhanVien.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucDanhSachNhanVien);
            }
            ucDanhSachNhanVien.BringToFront();
            ucDanhSachNhanVien.btnReLoad.PerformClick();

        }

        private ucDoiMatKhau ucDoiMatKhau = null;
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (ucDoiMatKhau == null)
            {
                ucDoiMatKhau = new ucDoiMatKhau(taiKhoan);
                ucDoiMatKhau.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucDoiMatKhau);
            }
            ucDoiMatKhau.BringToFront();


            //Invoke Event from ucDoiMatKhau
            ucDoiMatKhau.ForceSend += UcDoiMatKhau_ForceSend;
        }

        private void UcDoiMatKhau_ForceSend(object sender, bool forceExit)
        {
            if (forceExit)
            {
                this.forceExit = forceExit;
                this.Close();
            }
        }

        void UsingRole()
        {
            btnNhanVien.Visible = taiKhoan.isAdmin;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            UsingRole();
        }

        private ucThongTinCaNhan ucThongTinCaNhan;

        private void btnHT_TTCN_Click(object sender, EventArgs e)
        {
            if (ucThongTinCaNhan == null)
            {
                ucThongTinCaNhan = new ucThongTinCaNhan(taiKhoan);
                ucThongTinCaNhan.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucThongTinCaNhan);
            }
            ucThongTinCaNhan.BringToFront();

            ucThongTinCaNhan.ForceSend += UcThongTinCaNhan_ForceSend;
        }

        private void UcThongTinCaNhan_ForceSend(object sender, bool forceExit)
        {
            if (forceExit)
            {
                this.forceExit = forceExit;
                this.Close();
            }
        }
    }
}
