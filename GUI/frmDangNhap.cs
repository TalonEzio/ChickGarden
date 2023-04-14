using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraEditors;
using DTO;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        void EnableAdvancedMode()
        {
            txtPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            EnableAdvancedMode();
        }

        private void hlDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
            this.Show();
        }
        bool CheckInput()
        {
            err.ClearErrors();
            err.SetIconAlignment(txtUsername, ErrorIconAlignment.MiddleRight);
            err.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);

            if (txtPassword.Text.Length < 6 ) {
                err.SetError(txtPassword, "Mật khẩu phải 6 ký tự trở lên");
                return false;   
            }
            if (txtUsername.Text.Length < 6)
            {
                err.SetError(txtUsername, "Mật khẩu phải 6 ký tự trở lên");
                return false;

            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            TrangThai trangThai = TaiKhoanBLL.Instance.DangNhap(taiKhoan);
            if (trangThai == TrangThai.ThatBai)
            {
                XtraMessageBox.Show("Đăng nhập thất bại", "Trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                XtraMessageBox.Show("Đăng nhập thành công", "Trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiKhoanBLL.Instance.LayQuyen(taiKhoan);
                frmTrangChu frmTrangChu = new frmTrangChu(taiKhoan);
                this.Hide();
                txtUsername.Text = txtPassword.Text = "";
                frmTrangChu.ShowDialog();
                this.Show();
            }

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }    
        }

        private void hlQuenMatKhau_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/vuthemanh1707");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            txtPassword.Text = txtUsername.Text = "";
            this.Hide();
            frmDangKy.ShowDialog();
            this.Show();

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
