using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
                int maLDA = (int)view.GetFocusedRowCellValue("Loại đồ ăn");
                var newDSDA = DSDA.AsEnumerable()
                        .Where(doAn => doAn.MaLDA == maLDA)
                       .Distinct();
                editor.Properties.DataSource = newDSDA;
            }
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