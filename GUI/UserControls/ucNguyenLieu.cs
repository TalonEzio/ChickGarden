using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class ucNguyenLieu : UserControl
    {
        private TaiKhoan taiKhoan;
        public ucNguyenLieu(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        List<LoaiNguyenLieu> DSLoaiNguyenLieu = new List<LoaiNguyenLieu>()
        {
            new LoaiNguyenLieu(){MaLNL = 0,TenLNL = "Tất cả"}
        };
        List<LoaiNguyenLieu> DSLoaiNguyenLieuEdit;
        DataTable dt;
        DataTable insertData;
        DataTable updateData;
        DataTable deleteData;

        void TaiLoaiNguyenLieu(System.Windows.Forms.ComboBox comboBox)
        {
            DSLoaiNguyenLieu.AddRange(LoaiNguyenLieuBLL.Instance.LayLoaiNguyenLieu());
            if (DSLoaiNguyenLieuEdit == null)
            {
                DSLoaiNguyenLieuEdit = DSLoaiNguyenLieu.FindAll(lda => lda.MaLNL != 0);
            }
            comboBox.Items.Clear();
            comboBox.DataSource = DSLoaiNguyenLieu;
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = "TenLNL";
            comboBox.ValueMember = "MaLNL";
        }
        void CustomLoaiNguyenLieu()
        {
            RepositoryItemLookUpEdit cmbLoaiNguyenLieuEdit = new RepositoryItemLookUpEdit();
            cmbLoaiNguyenLieuEdit.DataSource = DSLoaiNguyenLieuEdit;
            cmbLoaiNguyenLieuEdit.DisplayMember = "TenLNL";
            cmbLoaiNguyenLieuEdit.ValueMember = "MaLNL";
            cmbLoaiNguyenLieuEdit.ShowHeader = false;
            cmbLoaiNguyenLieuEdit.NullText = "Chọn loại nguyên liệu";
            grvDSNL.Columns[grvDSNL.Columns.Count - 2].ColumnEdit = cmbLoaiNguyenLieuEdit;
        }
        void CustomSoLuong()
        {
            RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit();
            spinEdit.MinValue = 0;
            spinEdit.MaxValue = 1000;
            spinEdit.IsFloatValue = false;
            grvDSNL.Columns[1].ColumnEdit = spinEdit;
        }
        void CustomColumn()
        {
            CustomLoaiNguyenLieu();
            CustomSoLuong();
        }
        private void ucNguyenLieu_Load(object sender, EventArgs e)
        {
            TaiLoaiNguyenLieu(cmbLoaiNguyenLieu);
            TaiNguyenLieu();
            CustomColumn();
        }
        void TaiNguyenLieu(int maLNL = 0)
        {
            grDSNL.DataSource = null;
            dt = NguyenLieuBLL.Instance.LayNguyenLieu(maLNL);
            if (insertData == null) insertData = dt.Clone();
            grDSNL.DataSource = dt;
            grvDSNL.Columns[grvDSNL.Columns.Count - 1].Visible = false;
            grDSNL.RefreshDataSource();
            grDSNL.Refresh();
        }
        int insertCountTemp = 0;
        private void cmbLoaiNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiNguyenLieu.SelectedIndex == -1) return;

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
            LoaiNguyenLieu loaiNguyenLieu = (LoaiNguyenLieu)cmbLoaiNguyenLieu.SelectedItem;
            TaiNguyenLieu(loaiNguyenLieu.MaLNL);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grvDSNL.AddNewRow();
            int newRowHandle = grvDSNL.GetRowHandle(grvDSNL.DataRowCount);
            if (cmbLoaiNguyenLieu.SelectedIndex != 0)
                grvDSNL.SetRowCellValue(newRowHandle, "Loại nguyên liệu", cmbLoaiNguyenLieu.SelectedIndex);
            insertCountTemp++;
        }

        void DeleteData(DataTable deleteData)
        {
            int deletedCount = 0;

            foreach (DataRow row in deleteData.Rows)
            {
                TrangThai trangThai = NguyenLieuBLL.Instance.XoaNguyenLieu((int)row.ItemArray[4]);
                if (trangThai == TrangThai.ThanhCong)
                {
                    deletedCount++;
                }
            }
            XtraMessageBox.Show($"Xóa thành công {deletedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteData.Rows.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grvDSNL.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (deleteData == null) deleteData = dt.Clone();


            int[] selectedRows = grvDSNL.GetSelectedRows();

            DialogResult result = XtraMessageBox.Show($"bạn muốn xóa {selectedRows.Length} dòng đã chọn?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = selectedRows.Length - 1; i >= 0; i--)
                {
                    deleteData.Rows.Add(grvDSNL.GetDataRow(selectedRows[i]).ItemArray);
                    grvDSNL.DeleteRow(selectedRows[i]);
                }
                DeleteData(deleteData);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grvDSNL.UpdateCurrentRow();

            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            updateData = dt.GetChanges(DataRowState.Modified);
            UpdateData(updateData);

            cmbLoaiNguyenLieu.SelectedIndex = 0;
            TaiNguyenLieu();
        }
        bool ValidateBefore(NguyenLieu nguyenLieu)
        {
            if (nguyenLieu.TenNguyenLieu.Length < 3)
            {
                XtraMessageBox.Show($"Tên nguyên liệu: \"{nguyenLieu.TenNguyenLieu}\" quá ngắn, không cho phép thêm.");
                return false;
            }
            if (nguyenLieu.DonViTinh.Length == 0)
            {
                XtraMessageBox.Show($"Phải ghi đơn vị tính!");
                return false;
            }
            return true;
        }
        void InsertData(DataTable insertData)
        {
            int insertCount = 0;
            if (insertData == null)
            {
                return;
            }

            foreach (DataRow row in insertData.Rows)
            {
                NguyenLieu nguyenLieu = new NguyenLieu()
                {
                    TenNguyenLieu = row.ItemArray[0].ToString(),
                    SoLuongTon = (int)row.ItemArray[1],
                    DonViTinh = row.ItemArray[2].ToString()
                };
                if (ValidateBefore(nguyenLieu) == false) continue;
                int maLNL = (int)row.ItemArray[3];
                TrangThai trangThai = NguyenLieuBLL.Instance.ThemNguyenLieu(nguyenLieu, maLNL);
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
            if (updateData != null)
            {
                int updatedCount = 0;
                foreach (DataRow row in updateData.Rows)
                {
                    string tenNguyenLieu = row.ItemArray[0].ToString();
                    NguyenLieu nguyenLieu = new NguyenLieu()
                    {
                        TenNguyenLieu = tenNguyenLieu,
                        SoLuongTon = (int)row.ItemArray[1],
                        DonViTinh = row.ItemArray[2].ToString(),MaNguyenLieu = (int)row.ItemArray[row.ItemArray.Length - 1]
                    };
                    if (ValidateBefore(nguyenLieu) == false) continue;
                    int maLNL = (int)row.ItemArray[3];
                    TrangThai trangThai = NguyenLieuBLL.Instance.CapNhatNguyenLieu(nguyenLieu, maLNL);
                    if (trangThai == TrangThai.ThanhCong) updatedCount++;
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
}
