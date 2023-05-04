using BLL;
using DevExpress.Charts.Native;
using DevExpress.Office.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
namespace GUI.UserControls_ChildForm
{
    public partial class ucDoanhThuTheoThoiGian : UserControl
    {
        public ucDoanhThuTheoThoiGian()
        {
            InitializeComponent();
            btn.Click += Btn_Click;
        }

        void LoadNgay()
        {
            dtpNgayBatDau.DateTime = DateTime.Today.AddYears(-1);
            dtpNgayKetThuc.DateTime = DateTime.Today;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            LoadNgay();
            LoadDoanhThuTheoLoaiDoAn(DateTime.Today.AddYears(-1), DateTime.Today);
        }

        internal Button btn = new Button();
        void LoadDoanhThuTheoLoaiDoAn(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeDoanhThuTheoNhomDoAn(ngayBatDau, ngayKetThuc);
            if (dt.Rows.Count == 0) return;
            chart1.Series.Clear();

            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Loại đồ ăn", DevExpress.XtraCharts.ViewType.Bar);

            foreach (DataRow dr in dt.Rows)
            {
                series.Points.Add(
                    new DevExpress.XtraCharts.SeriesPoint(
                        dr[0].ToString(),
                        double.Parse(dr[1].ToString())));
            }
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.Label.TextPattern = "{V:#,##0,,.##} triệu đồng";
            series.Label.TextAlignment = System.Drawing.StringAlignment.Far;
            chart1.Series.Add(series);
        }
        
        private void ucThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            btn.PerformClick();
            btnFilter.PerformClick();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadDoanhThuTheoLoaiDoAn(dtpNgayBatDau.DateTime,dtpNgayKetThuc.DateTime);
            ChartTitle title = new ChartTitle();
            title.Text = $"Doanh thu từ {dtpNgayBatDau.DateTime.ToShortDateString()} tới {dtpNgayKetThuc.DateTime.ToShortDateString()} ";
            chart1.Titles.Clear();
            chart1.Titles.Add(title);   
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(chart1.IsPrintingAvailable)
            {
                sd1.Title = "Lưu tập tin";
                sd1.Filter = "Jpeg files (*.jpg)|*.jpg";
                sd1.FileName = $"Báo cáo doanh thu";

                if (sd1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sd1.FileName;
                    chart1.ExportToImage(filePath,ImageFormat.Jpeg);

                    if (XtraMessageBox.Show("Export thành công, bạn muốn xem chứ?", "Export", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && !string.IsNullOrEmpty(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
        }
    }
}
