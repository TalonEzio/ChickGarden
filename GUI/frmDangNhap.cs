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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == "") return;
            TrangThai trangThai = TaiKhoanBLL.Instance.DangNhap(txtUsername.Text, txtPassword.Text);
            if (trangThai == TrangThai.ThatBai)
            {
                XtraMessageBox.Show("Đăng nhập thất bại","Trạng thái",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập thành công", "Trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
                
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }    
        }
    }
}
