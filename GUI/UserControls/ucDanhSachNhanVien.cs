using BLL;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraExport.Helpers;
using DevExpress.Export.Xl;
using System.IO;

namespace GUI.UserControls
{
    public partial class ucDanhSachNhanVien : UserControl
    {
        List<GioiTinh> DSGT = new List<GioiTinh>()
        {
            new GioiTinh(){MaGioiTinh = 0,TenGioiTinh = "Nam"},
            new GioiTinh(){MaGioiTinh = 1,TenGioiTinh = "Nữ"},
            new GioiTinh(){MaGioiTinh = 2,TenGioiTinh = "Khác"}
        };
        List<ChucVu> DSCV = new List<ChucVu>()
        {
            new ChucVu(){MaChucVu = 1,TenChucVu = "Quản lý"},
            new ChucVu(){MaChucVu = 2,TenChucVu = "Nhân viên"},
        };
        public ucDanhSachNhanVien()
        {
            InitializeComponent();
        }
        private TaiKhoan taiKhoan;
        public ucDanhSachNhanVien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        private void ucDanhSachNhanVien_Load(object sender, EventArgs e)
        {

            dataTable = NhanVienBLL.Instance.LayDanhSach(taiKhoan.Username);
            grDSNV.DataSource = dataTable;
            deleteData = dataTable.Clone();
            CustomColumn();
        }

        void CustomGioiTinh()
        {
            RepositoryItemLookUpEdit cmbGioiTinh = new RepositoryItemLookUpEdit();
            cmbGioiTinh.DataSource = DSGT;
            cmbGioiTinh.DisplayMember = "TenGioiTinh";
            cmbGioiTinh.ValueMember = "MaGioiTinh";
            grvDSNV.Columns[1].ColumnEdit = cmbGioiTinh;
        }
        void CustomChucVu()
        {
            RepositoryItemLookUpEdit cmbChucVu = new RepositoryItemLookUpEdit();
            cmbChucVu.DataSource = DSCV;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
            grvDSNV.Columns[5].ColumnEdit = cmbChucVu;
        }

        void CustomColumn()
        {
            CustomGioiTinh();
            CustomChucVu();
            grvDSNV.Columns[6].Visible = false;

        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (deleteData.Rows.Count > 0)
            //{
            //    DialogResult result = XtraMessageBox.Show($"Bạn vừa xóa{deleteData.Rows.Count} dòng nhưng chưa lưu, bạn có muốn lưu lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    if (result == DialogResult.Cancel) return;
            //    if (result == DialogResult.Yes)
            //    {
            //        DeleteData();
            //    }
            //    deleteData.Rows.Clear();
            //}
            dataTable = NhanVienBLL.Instance.LayDanhSach(taiKhoan.Username);
            grDSNV.DataSource = dataTable;
        }
        DataTable dataTable = new DataTable();
        DataTable deleteData = null;

        bool ValidateBeforeUpdate(NhanVien nhanVien)
        {
            if (nhanVien.HoTen.Length < 6)
            {
                XtraMessageBox.Show($"Tên \"{nhanVien.HoTen}\" quá ngắn, phải 6 ký tự trở lên.\n Bỏ qua dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; ;
            }
            if (nhanVien.QueQuan.Length < 6)
            {
                XtraMessageBox.Show($"Quê quán \"{nhanVien.QueQuan}\" quá ngắn, phải 6 ký tự trở lên.\n Bỏ qua dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nhanVien.SoDienThoai.Length < 10 || nhanVien.SoDienThoai.Length > 15)
            {
                XtraMessageBox.Show($"SDT \"{nhanVien.SoDienThoai}\" phải từ 10 đến 15 ký tự.\n Bỏ qua dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int age = DateTime.Now.Year - nhanVien.NgaySinh.Year;
            if (age < 18)
            {
                XtraMessageBox.Show($"{nhanVien.HoTen} mới {age}, chưa đủ tuổi làm.\n Bỏ qua dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        int UpdateData()
        {
            int updatedCount = 0;
            DataTable modifiedData = dataTable.GetChanges(DataRowState.Modified);
            if (modifiedData != null)
            {
                foreach (DataRow row in modifiedData.Rows)
                {
                    string username = row["username"].ToString();

                    int maChucVu = (int)row[5];

                    NhanVien nhanVien = new NhanVien()
                    {
                        HoTen = row[0].ToString(),
                        NgaySinh = Convert.ToDateTime(row[2].ToString()),
                        QueQuan = row[3].ToString(),
                        SoDienThoai = row[4].ToString(),
                    };

                    if (!ValidateBeforeUpdate(nhanVien)) continue;

                    TrangThai trangThai = NhanVienBLL.Instance.CapNhatThongTin(nhanVien, maChucVu, username);
                    if (trangThai == TrangThai.ThanhCong) updatedCount++;
                }
                if (updatedCount == modifiedData.Rows.Count)
                {
                    XtraMessageBox.Show($"Đã cập nhật {updatedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show($"Có {modifiedData.Rows.Count - updatedCount} dòng cập nhật lỗi, hãy xem lại dữ liệu đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return updatedCount;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvDSNV.CloseEditor();
            grvDSNV.UpdateCurrentRow();
            int updatedCount = UpdateData();
            if (updatedCount == 0)
            {
                XtraMessageBox.Show($"Không có gì thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.ShowDialog();
            dataTable = NhanVienBLL.Instance.LayDanhSach(taiKhoan.Username);
            grDSNV.DataSource = dataTable;
        }

        void DeleteData(DataTable deleteData)
        {
            int deletedCount = 0;

            foreach (DataRow row in deleteData.Rows)
            {
                TrangThai trangThai = TaiKhoanBLL.Instance.XoaTaiKhoan(row["username"].ToString());
                if (trangThai == TrangThai.ThanhCong)
                {
                    deletedCount++;
                }
            }
            XtraMessageBox.Show($"Xóa thành công {deletedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvDSNV.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (deleteData == null) deleteData = dataTable.Clone();

            int[] selectedRows = grvDSNV.GetSelectedRows();

            DialogResult result = XtraMessageBox.Show($"bạn muốn xóa {selectedRows.Length} dòng đã chọn?","Xóa dữ liệu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                for (int i = selectedRows.Length - 1; i >= 0; i--)
                {
                    deleteData.Rows.Add(grvDSNV.GetDataRow(selectedRows[i]).ItemArray);
                    grvDSNV.DeleteRow(selectedRows[i]);
                }

                DeleteData(deleteData);
            }
            deleteData.Rows.Clear();
        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sdExcel.Title = "Lưu tập tin";
            sdExcel.Filter = "Excel files (*.xlsx)|*.xlsx|PDF files (*.pdf)|*.pdf|HTML files (*.html)|*.html|Word files (*.docx)|*.docx";
            sdExcel.FileName = "Danh sách nhân viên";

            if (sdExcel.ShowDialog() == DialogResult.OK)
            {
                string filePath = sdExcel.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                ExportTarget exportFormat;
                switch (fileExtension)
                {
                    case ".xlsx":
                        exportFormat = ExportTarget.Xlsx;
                        break;
                    case ".pdf":
                        exportFormat = ExportTarget.Pdf;
                        break;
                    case ".html":
                        exportFormat = ExportTarget.Html;
                        break;
                    case ".docx":
                        exportFormat = ExportTarget.Docx;
                        break;
                    default:
                        XtraMessageBox.Show("Định dạng file không hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                grvDSNV.Export(exportFormat, filePath);

                if (XtraMessageBox.Show("Export thành công, bạn muốn xem chứ?", "Export", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && !string.IsNullOrEmpty(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }

    }
}
