using BLL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
        void TaiLoaiDoAn(ComboBox comboBox)
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


        void TaiDoAn(GridControl gridControl, int? MaLDA = 0)
        {
            DataTable dt = DoAnBLL.Instance.LayDoAn(MaLDA);
            gridControl.DataSource = dt;
            GridView gridView = gridControl.Views[0] as GridView;
            gridView.Columns[gridView.Columns.Count - 1].Visible = false;
        }
        void CustomLoaiDoAn(GridView gridView)
        {
            RepositoryItemLookUpEdit cmbLoaiDoAnEdit = new RepositoryItemLookUpEdit();
            cmbLoaiDoAnEdit.DataSource = DSLoaiDoAnEdit;
            cmbLoaiDoAnEdit.DisplayMember = "TenLDA";
            cmbLoaiDoAnEdit.ValueMember = "MaLDA";
            cmbLoaiDoAnEdit.ShowHeader = false;
            cmbLoaiDoAnEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick;
            gridView.Columns[1].ColumnEdit = cmbLoaiDoAnEdit;
        }
        private void ucDanhSachDoAn_Load(object sender, EventArgs e)
        {
            TaiLoaiDoAn(cmbLoaiDoAn);

            CustomLoaiDoAn(grvDSDA);
        }

        private void cmbLoaiDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLoaiDoAn.SelectedIndex == -1) return;
            LoaiDoAn loaiDoAn = (LoaiDoAn)cmbLoaiDoAn.SelectedItem;
            TaiDoAn(grDSDA, loaiDoAn.MaLDA);

        }
    }
}
