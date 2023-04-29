using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
using GUI.UserControls;
using GUI.UserControls_ChildForm;
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
                ucDanhSachNhanVien = new ucDanhSachNhanVien(taiKhoan);
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
        ucDanhSachDoAn ucDanhSachDoAn;
        private void btnDA_DSDA_Click(object sender, EventArgs e)
        {
            if (ucDanhSachDoAn == null)
            {
                ucDanhSachDoAn = new ucDanhSachDoAn(taiKhoan);
                ucDanhSachDoAn.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucDanhSachDoAn);
            }
            ucDanhSachDoAn.BringToFront();
            ucDanhSachDoAn.btnReLoad.PerformClick();
        }
        ucPhieuNhap ucPhieuNhap;
        private void btnHD_PN_Click(object sender, EventArgs e)
        {
            if (ucPhieuNhap == null)
            {
                ucPhieuNhap = new ucPhieuNhap(taiKhoan);
                ucPhieuNhap.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucPhieuNhap);
            }
            ucPhieuNhap.BringToFront();
            ucPhieuNhap.btnReLoad.PerformClick();

        }
        ucNguyenLieu ucNguyenLieu;
        private void btnDA_DSNL_Click(object sender, EventArgs e)
        {
            if (ucNguyenLieu == null)
            {
                ucNguyenLieu = new ucNguyenLieu(taiKhoan);
                ucNguyenLieu.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucNguyenLieu);
            }
            ucNguyenLieu.BringToFront();
            ucNguyenLieu.btnReLoad.PerformClick();

        }
        ucPhieuXuat ucPhieuXuat;

        private void btnHD_PX_Click(object sender, EventArgs e)
        {
            if (ucPhieuXuat == null)
            {
                ucPhieuXuat = new ucPhieuXuat(taiKhoan);
                ucPhieuXuat.Dock = DockStyle.Fill;
                mainContainer.AddControl(ucPhieuXuat);
            }
            ucPhieuXuat.BringToFront();
            ucPhieuXuat.btnReLoad.PerformClick();
        }

        private void btnTK_Excel_Click(object sender, EventArgs e)
        {
        }
    }
}
