using BLL;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucPhieuNhap : UserControl
    {
        TaiKhoan taiKhoan;
        NhanVien nhanVien;
        List<NhaCungCap> DSNCC = NhaCungCapBLL.Instance.LayToanBoNhaCungCap();
        List<NhanVien> DSNV = NhanVienBLL.Instance.LayTatCaNhanVien();
        DataTable dt;
        public ucPhieuNhap(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.Username);
        }

        void TaiDanhSachPhieuNhap()
        {
            dt = PhieuNhapBLL.Instance.LayDanhSachPhieuNhap();
            grDSPN.DataSource = dt;
            grDSPN.EndUpdate();

        }
        void CustomColumnNhanVien()
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
            //cmbNhanVien.Columns["NgaySinh"].Visible = false;
            //cmbNhanVien.Columns["GioiTinh"].Visible = false;
            //cmbNhanVien.Columns["QueQuan"].Visible = false;
            //cmbNhanVien.Columns["SoDienThoai"].Visible = false;
            //cmbNhanVien.ShowHeader = false;

            grvDSPN.Columns[0].ColumnEdit = cmbNhanVien;
        }
        void CustomColumnNhaCungCap()
        {
            RepositoryItemLookUpEdit cmbNhaCungCap = new RepositoryItemLookUpEdit();
            cmbNhaCungCap.DataSource = DSNCC;
            cmbNhaCungCap.DisplayMember = "TenNCC";
            cmbNhaCungCap.ValueMember = "MaNCC";
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("MaNCC", "Mã NCC", 20));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("TenNCC", "Tên NCC", 50));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("DiaChi", "Địa chỉ ", 120));
            cmbNhaCungCap.Columns.Add(new LookUpColumnInfo("SoDienThoai", "Số điện thoại", 30));
            cmbNhaCungCap.Columns["MaNCC"].Visible = false;
            cmbNhaCungCap.ShowHeader = false;
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
                if(PhieuNhapBLL.Instance.CapNhatPhieuNhap(phieuNhap) == TrangThai.ThanhCong)
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
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvDSPN.CloseEditor();
            grvDSPN.UpdateCurrentRow();

            grvDSPN.FocusedColumn = grvDSPN.VisibleColumns[0];
            
            DataTable updateData = dt.GetChanges(DataRowState.Modified);
            if (updateData == null)
            {
                XtraMessageBox.Show("Chưa có thay đổi gì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateData(updateData);
            TaiDanhSachPhieuNhap();

        }
    }
}
