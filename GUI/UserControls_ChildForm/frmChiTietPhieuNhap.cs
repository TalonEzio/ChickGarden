using BLL;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmChiTietPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private PhieuNhap phieuNhap;
        public frmChiTietPhieuNhap(PhieuNhap phieuNhap)
        {
            InitializeComponent();
            this.phieuNhap = phieuNhap;
        }
        DataTable dt, insertData, deleteData, updateData;
        List<NguyenLieu> DSNL = new List<NguyenLieu>();
        void LoadData()
        {
            dt = ChiTietPhieuNhapBLL.Instance.LayDanhSachPhieuNhap(phieuNhap.MaPhieuNhap);
            dt.Columns[0].Unique = true;

            foreach (DataColumn dc in dt.Columns)
            {
                dc.AllowDBNull = false;
            }
            grCTPN.DataSource = dt;
        }
        void CustomNguyenLieu()
        {
            DataTable dataTable = NguyenLieuBLL.Instance.LayNguyenLieu();
            foreach (DataRow dr in dataTable.Rows)
            {
                DSNL.Add(new NguyenLieu()
                {
                    MaNguyenLieu = (int)dr.ItemArray[4],
                    TenNguyenLieu = dr.ItemArray[0].ToString(),
                    SoLuongTon = (int)dr.ItemArray[1],
                    DonViTinh = dr.ItemArray[2].ToString()
                });
            }
            RepositoryItemLookUpEdit cmbNguyenLieu = new RepositoryItemLookUpEdit();
            cmbNguyenLieu.DataSource = DSNL;
            cmbNguyenLieu.DisplayMember = "TenNguyenLieu";
            cmbNguyenLieu.ValueMember = "MaNguyenLieu";
            cmbNguyenLieu.ShowHeader = false;
            cmbNguyenLieu.NullText = "Chọn loại nguyên liệu";
            grvCTPN.Columns[0].ColumnEdit = cmbNguyenLieu;
        }
        
        void CustomSoLuong()
        {
            RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit();
            spinEdit.MinValue = 0;
            spinEdit.MaxValue = 1000;
            spinEdit.IsFloatValue = false;
            grvCTPN.Columns[2].ColumnEdit = spinEdit;
        }
        void CustomColumn()
        {
            CustomNguyenLieu();
            CustomSoLuong();
        }
        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            CustomColumn();
        }
        int insertCountTemp = 0;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPN.CloseEditor();
            grvCTPN.UpdateCurrentRow();
            grvCTPN.AddNewRow();
            insertCountTemp++;

        }

        private void grvCTPN_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvCTPN.SetRowCellValue(e.RowHandle, "Hạn sử dụng", DateTime.Now);
            grvCTPN.SetRowCellValue(e.RowHandle, "Số lượng", 0);
        }
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPN.CloseEditor();
            grvCTPN.UpdateCurrentRow();
            if (grvCTPN.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (deleteData == null) deleteData = dt.Clone();


            int[] selectedRows = grvCTPN.GetSelectedRows();

            DialogResult result = XtraMessageBox.Show($"bạn muốn xóa {selectedRows.Length} dòng đã chọn?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = selectedRows.Length - 1; i >= 0; i--)
                {
                    deleteData.Rows.Add(grvCTPN.GetDataRow(selectedRows[i]).ItemArray);
                    grvCTPN.DeleteRow(selectedRows[i]);
                }
                DeleteData(deleteData);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvCTPN.CloseEditor();
            grvCTPN.UpdateCurrentRow();
            insertData = dt.GetChanges(DataRowState.Added);
            InsertData(insertData);

            updateData = dt.GetChanges(DataRowState.Modified);
            UpdateData(updateData);
            LoadData();
        }

        void DeleteData(DataTable deleteData)
        {
            int deletedCount = 0;

            foreach (DataRow row in deleteData.Rows)
            {
                int maNguyenLieu = (int)row[0];
                TrangThai trangThai = ChiTietPhieuNhapBLL.Instance.XoaNguyenLieuKhoiCTPN(phieuNhap.MaPhieuNhap,maNguyenLieu);
                if (trangThai == TrangThai.ThanhCong)
                {
                    deletedCount++;
                }
            }
            XtraMessageBox.Show($"Xóa thành công {deletedCount} dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteData.Rows.Clear();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            LoadData();
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
                int maNguyenLieu = (int)row.ItemArray[0];
                double donGia = 0;
             
                bool convert = double.TryParse(row.ItemArray[1].ToString(),out donGia);
                if (convert == false) continue;

                int soLuong = (int)row.ItemArray[2]; 
                DateTime hanSuDung = DateTime.Parse(row.ItemArray[3].ToString());

                TrangThai trangThai = ChiTietPhieuNhapBLL.Instance.ThemNguyenLieuVaoCTPN
                    (new object[] { phieuNhap.MaPhieuNhap, maNguyenLieu, donGia, soLuong, hanSuDung });

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
            insertData.Rows.Clear();
        }
        void UpdateData(DataTable updateData)
        {
            if (updateData != null)
            {
                int updatedCount = 0;
                foreach (DataRow row in updateData.Rows)
                {
                    int maNguyenLieu = (int)row.ItemArray[0];
                    double donGia = 0;

                    bool convert = double.TryParse(row.ItemArray[1].ToString(), out donGia);
                    if (convert == false) continue;

                    int soLuong = (int)row.ItemArray[2];
                    DateTime hanSuDung = DateTime.Parse(row.ItemArray[3].ToString());

                    TrangThai trangThai = ChiTietPhieuNhapBLL.Instance.CapNhatNguyenLieuTrongCTPN(
                        new object[] { phieuNhap.MaPhieuNhap, maNguyenLieu, donGia, soLuong, hanSuDung });
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
    }
}