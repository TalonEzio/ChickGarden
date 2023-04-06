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
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHo.Text = txtTen.Text = txtQueQuan.Text = txtSoDienThoai.Text = txtUsername.Text = txtPassword.Text = "";
            dtpNgaySinh.Text = "";
            rdoNam.Checked = true;
            leChucVu.EditValue = null;

        }

        bool CheckInput()
        {
            err.ClearErrors();
            if(txtHo.Text.Length <= 0 ) {
                err.SetIconAlignment(txtHo, ErrorIconAlignment.MiddleRight);
                err.SetError(txtHo, "Yêu cầu nhập");
                return false;
            }
            if (txtTen.Text.Length <= 0)
            {
                err.SetIconAlignment(txtTen, ErrorIconAlignment.MiddleRight);
                err.SetError(txtTen, "Yêu cầu nhập");
                return false;
            }

            if(DateTime.Now.Year - dtpNgaySinh.DateTime.Year < 18)
            {
                err.SetIconAlignment(dtpNgaySinh, ErrorIconAlignment.MiddleRight);
                err.SetError(dtpNgaySinh, "Yêu cầu trên 18 tuổi");
                return false;
            }

            if(txtQueQuan.Text.Length <= 0)
            {
                err.SetIconAlignment(txtQueQuan, ErrorIconAlignment.MiddleRight);
                err.SetError(txtQueQuan, "Yêu cầu nhập");
                return false;
            }

            if (txtSoDienThoai.Text.Length <= 9)
            {
                err.SetIconAlignment(txtSoDienThoai, ErrorIconAlignment.MiddleRight);
                err.SetError(txtSoDienThoai, "Yêu cầu nhập trên 9 ký tự");
                return false;
            }

            if (txtUsername.Text.Length <= 5)
            {
                err.SetIconAlignment(txtUsername, ErrorIconAlignment.MiddleRight);
                err.SetError(txtUsername, "Yêu cầu nhập trên 5 ký tự");
                return false;
            }

            if (txtPassword.Text.Length <= 5)
            {
                err.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
                err.SetError(txtPassword, "Yêu cầu nhập trên 5 ký tự");
                return false;
            }

            if(leChucVu.EditValue == null || leChucVu.EditValue.ToString() == leChucVu.Properties.NullText)
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
                Ho = txtHo.Text,
                Ten = txtTen.Text,
                NgaySinh = Convert.ToDateTime(dtpNgaySinh.DateTime),
                QueQuan = txtQueQuan.Text,
                SoDienThoai = txtSoDienThoai.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                
            };
            if (rdoNam.Checked) taiKhoan.GioiTinh = 0;
            else if (rdoNu.Checked) taiKhoan.GioiTinh = 1;
            else taiKhoan.GioiTinh = 2;

            TrangThai trangThai = TaiKhoanBLL.Instance.DangKy(taiKhoan, new ChucVu() { MaChucVu = int.Parse(leChucVu.EditValue.ToString()) });
            if(trangThai == TrangThai.UserDaTonTai)
            {
                XtraMessageBox.Show("Tài khoản đã có trong hệ thống!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(trangThai == TrangThai.ThatBai)
            {
                XtraMessageBox.Show("Có lỗi trong quá trình đăng ký, vui lòng thử lại!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XtraMessageBox.Show("Đăng ký thành công, vui lòng đăng nhập!", "Trạng thái đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
            List<ChucVu> DSCV = ChucVuBLL.Instance.LayChucVu();
           if (DSCV == null)
            {
                XtraMessageBox.Show("Không có chức vụ", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            leChucVu.Properties.DataSource = DSCV;
            leChucVu.Properties.DisplayMember = "TenChucVu";
            leChucVu.Properties.ValueMember = "MaChucVu";
            leChucVu.Properties.NullText = "Chọn chức vụ";
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
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}