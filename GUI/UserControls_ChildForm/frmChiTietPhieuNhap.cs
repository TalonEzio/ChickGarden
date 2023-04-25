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
        DataTable dt;
        List<NguyenLieu> DSNL = new List<NguyenLieu>();
        void LoadData()
        {
            dt = ChiTietPhieuNhapBLL.Instance.LayDanhSachPhieuNhap(phieuNhap.MaPhieuNhap);
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
                    SoLuongTon =(int) dr.ItemArray[1],
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

            cmbNguyenLieu.EditValueChanged += CmbNguyenLieu_EditValueChanged;

        }

        private int previousValue = -1;

        private void CmbNguyenLieu_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit leNguyenLieu = (sender as LookUpEdit);

            int currentValue = (int)leNguyenLieu.EditValue;

            if (currentValue == previousValue)
            {
                return;
            }

            bool isDuplicate = false;
            for (int i = 0; i < grvCTPN.RowCount; i++)
            {
                if (currentValue == (int)grvCTPN.GetRowCellValue(i, "Nguyên liệu"))
                {
                    XtraMessageBox.Show("Nguyên liệu này đã có trong phiếu nhập, không thể chọn được!");
                    if (previousValue == -1)
                    {
                        previousValue = (int)leNguyenLieu.OldEditValue;
                    }
                    leNguyenLieu.EditValue = previousValue;

                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                // Cập nhật giá trị trong DataRow
                DataRow dr = grvCTPN.GetDataRow(grvCTPN.FocusedRowHandle);
                dr["Nguyên liệu"] = currentValue;

                // Cập nhật lại giá trị trong GridView
                grvCTPN.SetRowCellValue(grvCTPN.FocusedRowHandle, "Nguyên liệu", currentValue);

                // Cập nhật lại dữ liệu trên GridView
                grvCTPN.RefreshData();

                previousValue = currentValue;

            }

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
    }
}