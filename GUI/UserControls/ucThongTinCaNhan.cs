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
using BLL;
using DevExpress.XtraEditors;

namespace GUI.UserControls
{
    
    public partial class ucThongTinCaNhan : UserControl
    {
        public delegate void ForceExitSend(object sender, bool forceExit);
        public event ForceExitSend ForceSend;
        public ucThongTinCaNhan()
        {
            InitializeComponent();
        }
        private TaiKhoan taiKhoan;
        public ucThongTinCaNhan(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        NhanVien nhanVien;
        private void ucThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LayThongTinNhanVien(taiKhoan.Username);
        }
        private void LayThongTinNhanVien(string username)
        {
            nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(username);
            txtHoTen.Text = nhanVien.HoTen;
            txtQueQuan.Text = nhanVien.QueQuan;
            txtSoDienThoai.Text = nhanVien.SoDienThoai;
            dtpNgaySinh.DateTime = nhanVien.NgaySinh;
            switch (nhanVien.GioiTinh)
            {
                case 0:
                    rdoNam.Checked = true;
                    break;
                case 1:
                    rdoNu.Checked = true;
                    break;
                default:
                    rdoKhac.Checked = true;
                    break;
            }
        }
        bool KiemTraDauVao()
        {
                err.ClearErrors();
                if (txtHoTen.Text.Length < 5)
                {
                    err.SetIconAlignment(txtHoTen, ErrorIconAlignment.MiddleRight);
                    err.SetError(txtHoTen, "Yêu cầu nhập trên 5 ký tự");
                    return false;
                }
                int inputAge = DateTime.Now.Year - dtpNgaySinh.DateTime.Year;
                if (inputAge < 18)
                {
                    err.SetIconAlignment(dtpNgaySinh, ErrorIconAlignment.MiddleRight);
                    err.SetError(dtpNgaySinh, "Yêu cầu tuổi từ 18 trở lên");
                    return false;
                }
                if (txtQueQuan.Text.Length <= 5)
                {
                    err.SetIconAlignment(txtQueQuan, ErrorIconAlignment.MiddleRight);
                    err.SetError(txtQueQuan, "Yêu cầu nhập trên 5 ký tự");
                    return false;
                }
                if (txtSoDienThoai.Text.Length < 10 || txtSoDienThoai.Text.Length > 15)
                {
                    err.SetIconAlignment(txtSoDienThoai, ErrorIconAlignment.MiddleRight);
                    err.SetError(txtSoDienThoai, "Yêu cầu số điện thoại chỉ từ 10 đến 15 ký tự");
                    return false;
                }
            return true;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDauVao() == false) return;
            DialogResult result = XtraMessageBox.Show("Bạn muốn cập nhật thông tin mới chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {

                nhanVien.HoTen = txtHoTen.Text;
                nhanVien.QueQuan = txtQueQuan.Text;
                nhanVien.SoDienThoai = txtSoDienThoai.Text;
                nhanVien.NgaySinh = dtpNgaySinh.DateTime;

                if (rdoNam.Checked) nhanVien.GioiTinh = 0;
                else if (rdoNu.Checked) nhanVien.GioiTinh = 1;
                else nhanVien.GioiTinh = 2;

                TrangThai trangThai = NhanVienBLL.Instance.CapNhatThongTin(nhanVien, taiKhoan.Username);
                if(trangThai == TrangThai.ThanhCong)
                {
                    XtraMessageBox.Show("Cập nhật thông tin mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LayThongTinNhanVien(taiKhoan.Username);
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn sẽ phải liên hệ admin để cấp lại tài khoản.\n Vẫn muốn xóa chứ?", "Xóa tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                TrangThai trangThai = TaiKhoanBLL.Instance.XoaTaiKhoan(taiKhoan.Username);
                if(trangThai == TrangThai.ThanhCong)
                {
                    XtraMessageBox.Show("Tài khoản đã xóa khỏi hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.ForceSend?.Invoke(this, true);

                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ForceSend?.Invoke(this, false);

                }

            }
        }
    }
}
