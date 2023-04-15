using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class ucDoiMatKhau : UserControl
    {
        public delegate void ForceExitSend(object sender,bool forceExit);
        public event ForceExitSend ForceSend;
        private TaiKhoan taiKhoan;
        public ucDoiMatKhau()
        {
            InitializeComponent();
            
        }
        public ucDoiMatKhau(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        
        bool CheckInput()
        {
            err.ClearErrors();

            if (txtMatKhauHienTai.Text.Length < 6)
            {
                err.SetError(txtMatKhauHienTai, "Mật khẩu phải 6 ký tự trở lên");
                return false;
            }
            if (txtMatKhauHienTai.Text.IndexOf(' ') > -1)
            {
                err.SetError(txtMatKhauHienTai, "Yêu cầu mật khẩu không chứa khoảng trắng");
                return false;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                err.SetError(txtMatKhauMoi, "Mật khẩu phải 6 ký tự trở lên");
                return false;
            }
            if (txtMatKhauMoi.Text.IndexOf(' ') > -1)
            {
                err.SetError(txtMatKhauMoi, "Yêu cầu mật khẩu không chứa khoảng trắng");
                return false;
            }
            if (txtXacNhan.Text.Length < 6)
            {
                err.SetError(txtXacNhan, "Mật khẩu phải 6 ký tự trở lên");
                return false;
            }
            if (txtXacNhan.Text.IndexOf(' ') > -1)
            {
                err.SetError(txtXacNhan, "Yêu cầu mật khẩu không chứa khoảng trắng");
                return false;
            }
            if (txtMatKhauHienTai.Text != taiKhoan.Password)
            {
                err.SetError(txtMatKhauHienTai, "Mật khẩu hiện tại không đúng");
                return false;
            }    
            if(txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                err.SetError(txtXacNhan, "Mật khẩu xác nhận không khớp");
                return false;
            }   
            return true;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false) return;
            if(txtXacNhan.Text == taiKhoan.Password)
            {
                DialogResult result = XtraMessageBox.Show("Mật khẩu không có gì thay đổi, vẫn muốn đổi chứ?","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(result.Equals(DialogResult.No))
                {
                    return;
                } 
            }
            TrangThai trangThai = TaiKhoanBLL.Instance.DoiMatKhau(taiKhoan, txtMatKhauMoi.Text);
            if (trangThai == TrangThai.ThanhCong)
            {
                XtraMessageBox.Show("Đổi mật khẩu thành công, hãy đăng nhập lại!", "Trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Solution 1: Check parent form

                //Form parentForm = this.FindForm();
                //if(parentForm != null && parentForm is frmTrangChu)
                //{
                //    frmTrangChu frmTrangChu = (frmTrangChu)parentForm;
                //    frmTrangChu.ForceExit = true;
                //    frmTrangChu.Close();
                //}

                //Solution 2: raise event for parent form
                ForceSend?.Invoke(this, true);
            }
            else
            {
                XtraMessageBox.Show("Đổi mật khẩu thất bại!", "Trạng thái", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Solution 2: raise event for parent form
                ForceSend?.Invoke(this, false);
            }
        }

        private void ucDoiMatKhau_Load(object sender, EventArgs e)
        {
            err.SetIconAlignment(txtMatKhauHienTai, ErrorIconAlignment.MiddleRight);
            err.SetIconAlignment(txtMatKhauMoi, ErrorIconAlignment.MiddleRight);
            err.SetIconAlignment(txtXacNhan, ErrorIconAlignment.MiddleRight);
        }
    }
}
