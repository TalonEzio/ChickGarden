using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls_ChildForm
{
    public partial class ucPhieuXuat : UserControl
    {
        TaiKhoan taiKhoan;
        NhanVien nhanVien;
        DataTable dt, insertData, updateData, deleteData;
        List<NhanVien> DSNV = NhanVienBLL.Instance.LayTatCaNhanVien();
        int insertCountTemp = 0;

        public ucPhieuXuat(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.Username);
        }

        void TaiDanhSachPhieuXuat()
        {
            dt = PhieuXuatBLL.Instance.LayDanhSachPhieuXuat();
            grPhieuXuat.BeginUpdate();
            grPhieuXuat.DataSource = dt;

            if (insertData == null) insertData = dt.Clone();
            if (updateData == null) updateData = dt.Clone();
            if (deleteData == null) deleteData = dt.Clone();

            grPhieuXuat.EndUpdate();
        }
        void CustomNhanVien()
        {
            RepositoryItemLookUpEdit cmbNhanVien = new RepositoryItemLookUpEdit();
            cmbNhanVien.DataSource = DSNV;
            cmbNhanVien.DisplayMember = "HoTen";
            cmbNhanVien.ValueMember = "Id";
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("Id", "Mã nhân viên", 20));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("HoTen", "Họ tên", 50));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("SoDienThoai", "Số điện thoại", 50));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("NgaySinh", "Ngày sinh", 50));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("GioiTinh", "Giới tính", 50));
            cmbNhanVien.Columns.Add(new LookUpColumnInfo("QueQuan", "Quê quán", 50));
            cmbNhanVien.Columns["Id"].Visible = false;

            grvPhieuXuat.Columns[0].ColumnEdit = cmbNhanVien;
        }
        void CustomNgayBan()
        {
            RepositoryItemDateTimeOffsetEdit dtpNgayBan = new RepositoryItemDateTimeOffsetEdit();
            dtpNgayBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpNgayBan.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            dtpNgayBan.EditMask = "dd/MM/yyyy HH:mm:ss";
            grvPhieuXuat.Columns[1].ColumnEdit = dtpNgayBan;
        }
        void CustomColumns()
        {
            CustomNhanVien();
            CustomNgayBan();
        }
        private void ucPhieuXuat_Load(object sender, EventArgs e)
        {
            TaiDanhSachPhieuXuat();
            CustomColumns();
            grvPhieuXuat.Columns[grvPhieuXuat.Columns.Count - 1].Visible = false;
            grvPhieuXuat.Columns[grvPhieuXuat.Columns.Count - 2].OptionsColumn.ReadOnly = true;


        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvPhieuXuat.AddNewRow();
            insertCountTemp++;
        }

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
            TaiDanhSachPhieuXuat();
        }

        private void grvPhieuXuat_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[1], DateTimeOffset.Now);
        }
        frmChiTietPhieuXuat frmChiTietPhieuXuat;
        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowHandle = grvPhieuXuat.FocusedRowHandle;

            PhieuXuat phieuXuat = new PhieuXuat()
            {
                MaNV = (int)grvPhieuXuat.GetRowCellValue(rowHandle, "Người bán"),
                MaPhieuXuat = (int)grvPhieuXuat.GetRowCellValue(rowHandle, "MaHoaDon"),
                NgayBan = DateTimeOffset.Parse(grvPhieuXuat.GetRowCellValue(rowHandle, "Ngày bán").ToString()),
                MoTa = grvPhieuXuat.GetRowCellValue(rowHandle, "Mô tả").ToString(),
                TenKhachHang = grvPhieuXuat.GetRowCellValue(rowHandle, "Tên khách hàng").ToString()
            };

            if (frmChiTietPhieuXuat == null)
            {

                frmChiTietPhieuXuat = new frmChiTietPhieuXuat(phieuXuat);
            }
            else
            {
                this.Controls.Remove(frmChiTietPhieuXuat);
                frmChiTietPhieuXuat = new frmChiTietPhieuXuat(phieuXuat);

            }
            frmChiTietPhieuXuat.ShowDialog();
            TaiDanhSachPhieuXuat();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvPhieuXuat.CloseEditor();
            grvPhieuXuat.UpdateCurrentRow();

            grvPhieuXuat.FocusedColumn = grvPhieuXuat.VisibleColumns[0];

            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            DataTable updateData = dt.GetChanges(DataRowState.Modified);
            if (updateData == null)
            {
                return;
            }
            UpdateData(updateData);
            TaiDanhSachPhieuXuat();
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
                PhieuXuat phieuXuat = new PhieuXuat()
                {
                    MaNV = (int)dr[0],
                    NgayBan = DateTimeOffset.Parse(dr[1].ToString()),
                    TenKhachHang = dr[2].ToString(),
                    MoTa = dr[3].ToString(),
                    MaPhieuXuat = (int)dr[5]
                };

                TrangThai trangThai = PhieuXuatBLL.Instance.ThemPhieuXuat(phieuXuat);
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
        void UpdateData(DataTable updateData)
        {
            int updatedCount = 0;
            foreach (DataRow dr in updateData.Rows)
            {

                PhieuXuat phieuXuat = new PhieuXuat()
                {
                    MaNV = (int)dr[0],
                    NgayBan = DateTimeOffset.Parse(dr[1].ToString()),
                    TenKhachHang = dr[2].ToString(),
                    MoTa = dr[3].ToString(),
                    MaPhieuXuat = (int)dr[5]
                };

                TrangThai trangThai = PhieuXuatBLL.Instance.CapNhatPhieuXuat(phieuXuat);

                if (trangThai == TrangThai.ThanhCong)
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
    }

}
