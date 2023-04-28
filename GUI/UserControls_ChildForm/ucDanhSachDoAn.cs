using BLL;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraRichEdit.Fields;
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
    public partial class ucDanhSachDoAn : UserControl
    {
        private TaiKhoan taiKhoan;
        public ucDanhSachDoAn()
        {
            InitializeComponent();
        }
        public ucDanhSachDoAn(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }
        List<LoaiDoAn> DSLoaiDoAn = new List<LoaiDoAn>()
        {
            new LoaiDoAn(){MaLDA = 0,TenLDA = "Tất cả"}
        };
        List<LoaiDoAn> DSLoaiDoAnEdit;
        void TaiLoaiDoAn(System.Windows.Forms.ComboBox comboBox)
        {
            DSLoaiDoAn.AddRange(DoAnBLL.Instance.LayDanhSachLoaiDoAn());
            if (DSLoaiDoAnEdit == null)
            {
                DSLoaiDoAnEdit = DSLoaiDoAn.FindAll(lda => lda.MaLDA != 0);
            }
            comboBox.Items.Clear();
            comboBox.DataSource = DSLoaiDoAn;
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = "TenLDA";
            comboBox.ValueMember = "MaLDA";
        }

        DataTable dt;
        DataTable insertData;
        DataTable updateData;

        void TaiDoAn(int? MaLDA = 0)
        {
            grDSDA.DataSource = null;
            dt = DoAnBLL.Instance.LayDoAn(MaLDA);

            if (insertData == null) insertData = dt.Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.AllowDBNull = false;
            }
            grDSDA.DataSource = dt;
            grvDSDA.Columns[grvDSDA.Columns.Count - 1].Visible = false;
            grDSDA.RefreshDataSource();
            grDSDA.Refresh();
        }
        void CustomLoaiDoAn()
        {
            RepositoryItemLookUpEdit cmbLoaiDoAnEdit = new RepositoryItemLookUpEdit();
            cmbLoaiDoAnEdit.DataSource = DSLoaiDoAnEdit;
            cmbLoaiDoAnEdit.DisplayMember = "TenLDA";
            cmbLoaiDoAnEdit.ValueMember = "MaLDA";
            cmbLoaiDoAnEdit.ShowHeader = false;
            cmbLoaiDoAnEdit.NullText = "Chọn loại đồ ăn";
            grvDSDA.Columns[1].ColumnEdit = cmbLoaiDoAnEdit;
        }
        private void ucDanhSachDoAn_Load(object sender, EventArgs e)
        {
            TaiLoaiDoAn(cmbLoaiDoAn);
            TaiDoAn(0);
            CustomLoaiDoAn();

        }

        private void cmbLoaiDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbLoaiDoAn.SelectedIndex == -1) return;

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

            LoaiDoAn loaiDoAn = (LoaiDoAn)cmbLoaiDoAn.SelectedItem;
            TaiDoAn(loaiDoAn.MaLDA);
        }
        int insertCountTemp = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grvDSDA.AddNewRow();
            int newRowHandle = grvDSDA.GetRowHandle(grvDSDA.DataRowCount);
            if (cmbLoaiDoAn.SelectedIndex != 0)
                grvDSDA.SetRowCellValue(newRowHandle, "Loại đồ ăn", cmbLoaiDoAn.SelectedIndex);
            insertCountTemp++;

        }
        bool ValidateBefore(string tenDoAn)
        {
            if (tenDoAn.Length < 3)
            {
                XtraMessageBox.Show($"Tên đồ ăn:{tenDoAn} quá ngắn, không cho phép thêm.");
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
                string tenDoAn = row.ItemArray[0].ToString();
                int MaLDA = (int)row.ItemArray[1];
                if (ValidateBefore(tenDoAn) == false) continue;
                TrangThai trangThai = DoAnBLL.Instance.ThemDoAn(tenDoAn, MaLDA);
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
                    string tenDoAn = row.ItemArray[0].ToString();
                    int maLDA = (int)row.ItemArray[1];
                    int maDoAn = (int)row.ItemArray[2];

                    if (!ValidateBefore(tenDoAn)) continue;
                    TrangThai trangThai = DoAnBLL.Instance.CapNhatDoAn(maDoAn, tenDoAn, maLDA);
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            grvDSDA.UpdateCurrentRow();

            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            updateData = dt.GetChanges(DataRowState.Modified);
            UpdateData(updateData);

            cmbLoaiDoAn.SelectedIndex = 0;
            TaiDoAn();
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

            TaiDoAn();
            cmbLoaiDoAn.SelectedIndex = 0;
        }
        DataTable deleteData;
        void DeleteData(DataTable deleteData)
        {
            int deletedCount = 0;

            foreach (DataRow row in deleteData.Rows)
            {
                TrangThai trangThai = DoAnBLL.Instance.XoaDoAn((int)row.ItemArray[2]);
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
            if (grvDSDA.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (deleteData == null) deleteData = dt.Clone();


            int[] selectedRows = grvDSDA.GetSelectedRows();

            DialogResult result = XtraMessageBox.Show($"bạn muốn xóa {selectedRows.Length} dòng đã chọn?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = selectedRows.Length - 1; i >= 0; i--)
                {
                    deleteData.Rows.Add(grvDSDA.GetDataRow(selectedRows[i]).ItemArray);
                    grvDSDA.DeleteRow(selectedRows[i]);
                }
                DeleteData(deleteData);
            }
        }
    }
}
