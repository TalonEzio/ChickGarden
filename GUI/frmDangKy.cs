using BLL;
using DevExpress.XtraEditors;
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
using System.Windows.Input;

namespace GUI
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        private bool forceExit = false;
        DateTime maxAllowDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = txtMatKhau.Text = txtQueQuan.Text = txtSoDienThoai.Text = txtTaiKhoan.Text = "";
            dtpNgaySinh.DateTime = maxAllowDate;
            leChucVu.EditValue = null;

        }

        bool CheckInput()
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
            if (txtTaiKhoan.Text.Length < 6)
            {
                err.SetIconAlignment(txtTaiKhoan, ErrorIconAlignment.MiddleRight);
                err.SetError(txtTaiKhoan, "Yêu cầu tài khoản 6 ký tự trở lên");
                return false;
            }
            if (txtTaiKhoan.Text.IndexOf(' ') > -1)
            {
                err.SetIconAlignment(txtTaiKhoan, ErrorIconAlignment.MiddleRight);
                err.SetError(txtTaiKhoan, "Yêu cầu tài khoản không chứa khoảng trắng");
                return false;
            }
            if (txtMatKhau.Text.Length < 6)
            {
                err.SetIconAlignment(txtMatKhau, ErrorIconAlignment.MiddleRight);
                err.SetError(txtMatKhau, "Yêu cầu tài khoản 6 ký tự trở lên");
                return false;
            }
            if (txtMatKhau.Text.IndexOf(' ') > -1)
            {
                err.SetIconAlignment(txtMatKhau, ErrorIconAlignment.MiddleRight);
                err.SetError(txtMatKhau, "Yêu cầu mật khẩu không chứa khoảng trắng");
                return false;
            }

            if (leChucVu.EditValue == null || leChucVu.EditValue.ToString() == leChucVu.Properties.NullText)
            {
                err.SetIconAlignment(leChucVu, ErrorIconAlignment.MiddleRight);
                err.SetError(leChucVu, "Yêu cầu chọn chức vụ");
                return false;
            }

            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                Username = txtTaiKhoan.Text,
                Password = txtMatKhau.Text,
            };

            NhanVien nhanVien = new NhanVien()
            {
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.DateTime,
                QueQuan = txtQueQuan.Text,
                SoDienThoai = txtSoDienThoai.Text
            };

            if (rdoNam.Checked) nhanVien.GioiTinh = 0;
            else if (rdoNu.Checked) nhanVien.GioiTinh = 1;
            else nhanVien.GioiTinh = 2;

            ChucVu chucVu = new ChucVu()
            {
                MaChucVu = (int)leChucVu.EditValue
            };

            TrangThai trangThai = TaiKhoanBLL.Instance.DangKy(taiKhoan, nhanVien, chucVu);
            if (trangThai == TrangThai.UserDaTonTai)
            {
                XtraMessageBox.Show("Tài khoản đã có trong hệ thống!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (trangThai == TrangThai.ThatBai)
            {
                XtraMessageBox.Show("Có lỗi trong quá trình đăng ký, vui lòng thử lại!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XtraMessageBox.Show("Đăng ký thành công!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLamLai.PerformClick();

            forceExit = true;
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.DateTime = maxAllowDate;
            rdoNam.Checked = true;
            List<ChucVu> DSCV = ChucVuBLL.Instance.LayChucVu();
            if (DSCV == null)
            {
                XtraMessageBox.Show("Không có chức vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            leChucVu.Properties.DataSource = DSCV;
            leChucVu.Properties.DisplayMember = "TenChucVu";
            leChucVu.Properties.ValueMember = "MaChucVu";
            leChucVu.Properties.NullText = "Chọn chức vụ";
            leChucVu.Properties.PopulateColumns();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == (char)Key.Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!forceExit)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }    
        }
    }
}