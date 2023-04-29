using BLL;
using DevExpress.CodeParser;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DTO;
using GUI.UserControls_ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Reports;

namespace GUI.UserControls
{
    public partial class ucPhieuNhap : UserControl
    {
        TaiKhoan taiKhoan;
        NhanVien nhanVien;
        List<NhaCungCap> DSNCC = NhaCungCapBLL.Instance.LayToanBoNhaCungCap();
        List<NhanVien> DSNV = NhanVienBLL.Instance.LayTatCaNhanVien();
        DataTable dt, insertData;
        public ucPhieuNhap(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.Username);
            nhanVien.Id = NhanVienBLL.Instance.LayMaNhanVien(taiKhoan.Username);
        }

        void TaiDanhSachPhieuNhap()
        {
            dt = PhieuNhapBLL.Instance.LayDanhSachPhieuNhap();
            foreach (DataColumn dc in dt.Columns)
            {
                dc.AllowDBNull = false;
            }
            dt.Columns[4].AllowDBNull = true;
            grDSPN.BeginUpdate();
            grDSPN.DataSource = dt;
            if (insertData == null) insertData = dt.Clone();
            grDSPN.EndUpdate();

        }
        void CustomColumnNhanVien()
        {
            RepositoryItemLookUpEdit cmbNhanVien = new RepositoryItemLookUpEdit();
            cmbNhanVien.DataSource = DSNV;
            cmbNhanVien.DisplayMember = "HoTen";
            cmbNhanVien.ValueMember = "Id";
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("Id", "Mã nhân viên"));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("HoTen", "Họ tên"));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("SoDienThoai", "Số điện thoại"));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("NgaySinh", "Ngày sinh"));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("GioiTinh", "Giới tính"));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("QueQuan", "Quê quán"));
            cmbNhanVien.Columns["Id"].Visible = false;

            grvDSPN.Columns[0].ColumnEdit = cmbNhanVien;
        }
        void CustomColumnNhaCungCap()
        {
            RepositoryItemLookUpEdit cmbNhaCungCap = new RepositoryItemLookUpEdit();
            cmbNhaCungCap.DataSource = DSNCC;
            cmbNhaCungCap.DisplayMember = "TenNCC";
            cmbNhaCungCap.ValueMember = "MaNCC";
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("MaNCC", "Mã NCC"));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("TenNCC", "Tên NCC"));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("DiaChi", "Địa chỉ "));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("SoDienThoai", "Số điện thoại"));
            cmbNhaCungCap.Columns["MaNCC"].Visible = false;
            //cmbNhaCungCap.ShowHeader = false;
            grvDSPN.Columns[1].ColumnEdit = cmbNhaCungCap;
        }
        void CustomNgayNhap()
        {
            RepositoryItemDateTimeOffsetEdit dtpNgayNhap = new RepositoryItemDateTimeOffsetEdit();
            dtpNgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpNgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.EditMask = "dd/MM/yyyy HH:mm:ss";
            grvDSPN.Columns[2].ColumnEdit = dtpNgayNhap;
        }
        void CustomColumns()
        {
            CustomColumnNhanVien();
            CustomColumnNhaCungCap();
            CustomNgayNhap();
            grvDSPN.Columns[grvDSPN.Columns.Count - 1].Visible = false;
            grvDSPN.Columns[grvDSPN.Columns.Count - 2].OptionsColumn.ReadOnly = true;


        }
        private void ucPhieuNhap_Load(object sender, EventArgs e)
        {
            TaiDanhSachPhieuNhap();
            CustomColumns();
        }

        void UpdateData(DataTable updateData)
        {
            int updatedCount = 0;
            foreach (DataRow dr in updateData.Rows)
            {

                PhieuNhap phieuNhap = new PhieuNhap()
                {
                    MaPhieuNhap = (int)dr.ItemArray[5],
                    MaNCC = (int)dr.ItemArray[1],
                    NgayNhap = DateTimeOffset.Parse(dr.ItemArray[2].ToString()),
                    MaNV = (int)dr.ItemArray[0],
                    MoTa = dr.ItemArray[3].ToString(),
                };
                if (PhieuNhapBLL.Instance.CapNhatPhieuNhap(phieuNhap) == TrangThai.ThanhCong)
                {
                    updatedCount++;
                }
            }
            if (updatedCount == updateData.Rows.Count)
            {
                XtraMessageBox.Show($"Đã cập nhật {updatedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show($"Có {updateData.Rows.Count - updatedCount} dòng cập nhật lỗi, hãy xem lại dữ liệu đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        void InsertData(DataTable insertData)
        {
            int insertCount = 0;
            if (insertData == null)
            {
                return;
            }

            foreach (DataRow dr in insertData.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap()
                {
                    MaPhieuNhap = (int)dr.ItemArray[5],
                    MaNCC = (int)dr.ItemArray[1],
                    NgayNhap = DateTimeOffset.Parse(dr.ItemArray[2].ToString()),
                    MaNV = (int)dr.ItemArray[0],
                    MoTa = dr.ItemArray[3].ToString(),
                };

                TrangThai trangThai = PhieuNhapBLL.Instance.ThemPhieuNhap(phieuNhap);
                if (trangThai == TrangThai.ThanhCong)
                {
                    insertCount++;
                }
            }

            if (insertCount == insertData.Rows.Count)
            {
                XtraMessageBox.Show($"Đã thêm {insertCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show($"Có {insertCountTemp} dòng cập nhật lỗi, hãy xem lại dữ liệu đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            insertCountTemp = 0;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvDSPN.CloseEditor();
            grvDSPN.UpdateCurrentRow();

            grvDSPN.FocusedColumn = grvDSPN.VisibleColumns[0];

            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            DataTable updateData = dt.GetChanges(DataRowState.Modified);
            if (updateData == null)
            {
                return;
            }
            UpdateData(updateData);
            TaiDanhSachPhieuNhap();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowHandle = grvDSPN.GetSelectedRows()[0];
            if (rowHandle == -1) return;

            NhaCungCap nhaCungCap = NhaCungCapBLL.Instance.LayNhaCungCapTheoMa((int)grvDSPN.GetRowCellValue(rowHandle, "Nhà cung cấp"));
            rpPhieuNhap rpPhieuNhap = new rpPhieuNhap(nhaCungCap);
            rpPhieuNhap.ShowPreview();
        }
        int insertCountTemp = 0;

        private void btnReLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (insertCountTemp > 0)
            {
                DialogResult result = XtraMessageBox.Show($"Có {insertCountTemp} dòng chưa thêm, bạn muốn tải lại chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No) { return; }

                if (result == DialogResult.Yes)
                {
                    insertData.Rows.Clear();
                    insertCountTemp = 0;
                }
            }
            TaiDanhSachPhieuNhap();
        }

        private void grvDSPN_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[0],nhanVien.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns[2], DateTimeOffset.Now);
            view.SetRowCellValue(e.RowHandle, view.Columns[4], 0);


        }
        frmChiTietPhieuNhap frmChiTietPhieuNhap = null;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowHandle = grvDSPN.FocusedRowHandle;

            PhieuNhap phieuNhap = new PhieuNhap()
            {
                 MaNV = (int)grvDSPN.GetRowCellValue(rowHandle, "Người tạo hóa đơn"),
                 MaNCC = (int)grvDSPN.GetRowCellValue(rowHandle,"Nhà cung cấp"),
                 NgayNhap = DateTimeOffset.Parse(grvDSPN.GetRowCellValue(rowHandle,"Ngày nhập").ToString()),
                 MoTa = grvDSPN.GetRowCellValue(rowHandle,"Mô tả").ToString(),
                 MaPhieuNhap = (int)grvDSPN.GetRowCellValue(rowHandle,"MaPhieuNhap")

            };
            if(frmChiTietPhieuNhap == null)
            {
                frmChiTietPhieuNhap = new frmChiTietPhieuNhap(phieuNhap);
            }
            else
            {
                this.Controls.Remove(frmChiTietPhieuNhap);
                frmChiTietPhieuNhap = new frmChiTietPhieuNhap(phieuNhap);
            }
            frmChiTietPhieuNhap.ShowDialog();
            TaiDanhSachPhieuNhap();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvDSPN.AddNewRow();
            insertCountTemp++;
        }
    }
}
