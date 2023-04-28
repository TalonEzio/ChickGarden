using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmChiTietPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        PhieuXuat phieuXuat;
        private int insertCountTemp = 0;
        DataTable dt, insertData, updateData, deleteData;
        List<LoaiDoAn> DSLDA = DoAnBLL.Instance.LayDanhSachLoaiDoAn();
        List<DoAn> DSDA = DoAnBLL.Instance.LayTatCaDoAn();

        RepositoryItemLookUpEdit cmbDoAn = new RepositoryItemLookUpEdit();
        RepositoryItemLookUpEdit cmbLoaiDoAn = new RepositoryItemLookUpEdit();

        public frmChiTietPhieuXuat(PhieuXuat phieuXuat)
        {
            this.phieuXuat = phieuXuat;
            InitializeComponent();
        }

        void TaiChiTietPhieuXuat()
        {
            grCTPX.BeginUpdate();

            dt = ChiTietPhieuXuatBLL.Instance.LayChiTietPhieuXuat(phieuXuat.MaPhieuXuat);
            dt.Columns[1].Unique = true;
            foreach (DataColumn dc in dt.Columns)
            {
                dc.AllowDBNull = false;
            }
            dt.Columns[0].AllowDBNull = true;
            grCTPX.DataSource = dt;
            grCTPX.EndUpdate();
        }
        void CustomLoaiDoAn()
        {
            cmbLoaiDoAn.DataSource = DSLDA;
            cmbLoaiDoAn.DisplayMember = "TenLDA";
            cmbLoaiDoAn.ValueMember = "MaLDA";

            cmbLoaiDoAn.Columns.Add(new LookUpColumnInfo("MaLDA", "Mã", 20));
            cmbLoaiDoAn.Columns.Add(new LookUpColumnInfo("TenLDA", "Loại đồ ăn", 30));
            cmbLoaiDoAn.ShowHeader = false;
            cmbLoaiDoAn.Columns[0].Visible = false;
            cmbLoaiDoAn.NullText = "Chọn loại đồ ăn";
            grvCTPX.Columns[0].ColumnEdit = cmbLoaiDoAn;
            cmbLoaiDoAn.EditValueChanged += CmbLoaiDoAn_EditValueChanged;
        }

        private void CmbLoaiDoAn_EditValueChanged(object sender, EventArgs e)
        {
            grvCTPX.PostEditor();
            grvCTPX.SetFocusedRowCellValue("Đồ ăn", null);
        }


        void CustomDoAn()
        {
            cmbDoAn.DataSource = DSDA;
            cmbDoAn.DisplayMember = "TenDoAn";
            cmbDoAn.ValueMember = "MaDoAn";
            cmbDoAn.NullText = "Chọn đồ ăn";
            cmbDoAn.ShowHeader = false;

            cmbDoAn.Columns.Add(new LookUpColumnInfo("MaDoAn", "Mã", 20));
            cmbDoAn.Columns.Add(new LookUpColumnInfo("TenDoAn", "Tên đồ ăn", 30));
            cmbDoAn.Columns.Add(new LookUpColumnInfo("MaLDA", "Loại đồ ăn", 30));
            cmbDoAn.Columns[0].Visible = false;
            cmbDoAn.Columns[2].Visible = false;

            grvCTPX.Columns[1].ColumnEdit = cmbDoAn;

        }




        private void grvCTPX_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "Đồ ăn")
            {
                LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
                if(view.GetFocusedRowCellValue("Loại đồ ăn") != DBNull.Value)
                {
                    int maLDA = (int)view.GetFocusedRowCellValue("Loại đồ ăn");
                    var newDSDA = DSDA.AsEnumerable()
                            .Where(doAn => doAn.MaLDA == maLDA)
                           .Distinct();
                    editor.Properties.DataSource = newDSDA;
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPX.CloseEditor();
            grvCTPX.UpdateCurrentRow();

            if (grvCTPX.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (deleteData == null) deleteData = dt.Clone();


            int[] selectedRows = grvCTPX.GetSelectedRows();

            DialogResult result = XtraMessageBox.Show($"bạn muốn xóa {selectedRows.Length} dòng đã chọn?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = selectedRows.Length - 1; i >= 0; i--)
                {
                    deleteData.Rows.Add(grvCTPX.GetDataRow(selectedRows[i]).ItemArray);
                    grvCTPX.DeleteRow(selectedRows[i]);
                }
                DeleteData(deleteData);
            }
            TaiChiTietPhieuXuat();
        }
        void DeleteData(DataTable deleteData)
        {
            int deletedCount = 0;

            foreach (DataRow row in deleteData.Rows)
            {
                TrangThai trangThai = ChiTietPhieuXuatBLL.Instance.XoaDoAnKhoiCTPX(phieuXuat.MaPhieuXuat, (int)row[1]);
                if (trangThai == TrangThai.ThanhCong) deletedCount++;
            }
            if (deletedCount == deleteData.Rows.Count)
            {
                XtraMessageBox.Show($"Đã xóa {deletedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show($"Có {deleteData.Rows.Count - deletedCount} dòng xóa lỗi, hãy xem lại dữ liệu đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            deleteData.Rows.Clear();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPX.CloseEditor();
            grvCTPX.UpdateCurrentRow();
            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            updateData = dt.GetChanges(DataRowState.Modified);
            UpdateData(updateData);

            TaiChiTietPhieuXuat();
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
                object[] input;
                int maDoAn = (int)row[1];
                int soLuong = (int)row[3];
                double donGia;
                bool check = double.TryParse(row[2].ToString(), out donGia);
                if (check == false) continue;
                input = new object[] { phieuXuat.MaPhieuXuat, maDoAn, soLuong, donGia };
                TrangThai trangThai = ChiTietPhieuXuatBLL.Instance.ThemDoAnVaoPhieuXuat(input);
                if (trangThai == TrangThai.ThanhCong) insertCount++;
            }

            if (insertCount == insertData.Rows.Count)
            {
                XtraMessageBox.Show($"Đã thêm {insertCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show($"Có {insertData.Rows.Count - insertCount} dòng cập nhật lỗi, hãy xem lại dữ liệu đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            insertCountTemp = 0;
            insertData.Rows.Clear();
        }
        void UpdateData(DataTable updateData)
        {
            if (updateData != null)
            {
                int updatedCount = 0;
                foreach (DataRow row in updateData.Rows)
                {
                    object[] input;
                    int maDoAn = (int)row[1];
                    int soLuong = (int)row[2];
                    double donGia;
                    bool check = double.TryParse(row[3].ToString(), out donGia);
                    if (check == false) continue;
                    input = new object[] { phieuXuat.MaPhieuXuat, maDoAn, soLuong, donGia };
                    TrangThai trangThai = ChiTietPhieuXuatBLL.Instance.CapNhatDoAnTrongCTPX(input);
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
                updateData.Rows.Clear();

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPX.PostEditor();
            grvCTPX.UpdateCurrentRow();
            grvCTPX.AddNewRow();
            insertCountTemp++;
        }

        void CustomSoLuong()
        {
            RepositoryItemSpinEdit spin = new RepositoryItemSpinEdit();
            spin.MinValue = 1;
            spin.MaxValue = 100;
            spin.IsFloatValue = false;
            grvCTPX.Columns[3].ColumnEdit = spin;
        }
        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            TaiChiTietPhieuXuat();
            CustomLoaiDoAn();
            CustomDoAn();
            CustomSoLuong();


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPX.CloseEditor();
            grvCTPX.UpdateCurrentRow();
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
            TaiChiTietPhieuXuat();
        }
    }
}