using BLL;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GUI.UserControls_ChildForm
{
    public partial class ucLoiNhuanTheoNam : UserControl
    {
        public ucLoiNhuanTheoNam()
        {
            InitializeComponent();
            this.Load += UcLoiNhuanTheoNam_Load;
        }

        private void UcLoiNhuanTheoNam_Load(object sender, EventArgs e)
        {
            TaiDanhSachNam(5);
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            if (chart2.IsPrintingAvailable)
            {
                sd2.Title = "Lưu tập tin";
                sd2.Filter = "Jpeg files (*.jpg)|*.jpg";
                sd2.FileName = $"Thu nhập năm{(int)cmbNamCanXem.SelectedValue}";

                if (sd2.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sd2.FileName;
                    chart2.ExportToImage(filePath, ImageFormat.Jpeg);

                    if (XtraMessageBox.Show("Export thành công, bạn muốn xem chứ?", "Export",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && !string.IsNullOrEmpty(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
        }
        Series ThuTien(int nam)
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeDoanhThuTheoNam(nam);
            if (dt.Rows.Count == 0) return null;
            chart2.Series.Clear();
            Series series = new Series("Doanh thu", ViewType.Area);

            foreach (DataRow dr in dt.Rows)
            {
                double doanhThu = double.Parse(dr[1].ToString());
                series.Points.Add(
                    new SeriesPoint(
                        dr[0].ToString(), doanhThu
                       ));
            }
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.Label.TextPattern = "{V:#,##0,,.##} triệu đồng";
            return series;
        }

        Series ChiTien(int nam)
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeChiTieuTheoNam(nam);
            if (dt.Rows.Count == 0) return null;
            Series series = new Series("Chi tiêu", ViewType.Area);

            foreach (DataRow dr in dt.Rows)
            {
                double doanhThu = double.Parse(dr[1].ToString());
                if (doanhThu == 0) continue;
                series.Points.Add(
                    new SeriesPoint(
                        dr[0].ToString(), doanhThu
                       ));
            }
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            series.Label.TextPattern = "{V:#,##0,,.##} triệu đồng";
            return series;
        }
        void LoadSoTienTheoNam(int nam)
        {
            Series series1 = ThuTien(nam);
            Series series2 = ChiTien(nam);
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);

        }

        List<int> namThongKe = new List<int>();
        void TaiDanhSachNam(int soLuong)
        {
            int namHienTai = DateTime.Now.Year;
            for (int i = 0; i < soLuong; ++i)
            {
                namThongKe.Add(namHienTai - i);
            }
            cmbNamCanXem.DataSource = namThongKe;
            cmbNamCanXem.SelectedIndex = 0;
        }

        private void cmbNamCanXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbNamCanXem.SelectedIndex == -1) { return; }
            int nam = (int)cmbNamCanXem.SelectedValue;
            LoadSoTienTheoNam(nam);
        }
    }
}
