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
    public partial class ucThongKeDoanhThu : UserControl
    {
        public ucThongKeDoanhThu()
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
            LoadSoTienTheoNam(DateTime.Now.Year);
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
        DevExpress.XtraCharts.Series ThuTien(int nam)
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeDoanhThuTheoNam(nam);
            if (dt.Rows.Count == 0) return null;
            chart2.Series.Clear();
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Doanh thu", DevExpress.XtraCharts.ViewType.Area);

            foreach (DataRow dr in dt.Rows)
            {
                double doanhThu = double.Parse(dr[1].ToString());
                //if (doanhThu == 0) continue;
                series.Points.Add(
                    new DevExpress.XtraCharts.SeriesPoint(
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
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Chi tiêu", DevExpress.XtraCharts.ViewType.Area);

            foreach (DataRow dr in dt.Rows)
            {
                double doanhThu = double.Parse(dr[1].ToString());
                if (doanhThu == 0) continue;
                series.Points.Add(
                    new DevExpress.XtraCharts.SeriesPoint(
                        dr[0].ToString(), doanhThu
                       ));
            }
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

            series.Label.TextPattern = "{V:#,##0,,.##} triệu đồng";
            return series;
        }
        void LoadSoTienTheoNam(int nam)
        {
            DevExpress.XtraCharts.Series series1 = ThuTien(nam);
            DevExpress.XtraCharts.Series series2 = ChiTien(nam);
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
        }
        private void ucThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            btn.PerformClick();
            btnFilter.PerformClick();
            TaiDanhSachNam(5);
            cmbNamCanXem.DataSource = namThongKe;
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


        private void cmbNamCanXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
            if (cmb.SelectedIndex == -1)
            {
                cmb.SelectedIndex = 0;
            }
            chart2.Titles.Clear();

            ChartTitle title = new ChartTitle();
            title.Text = $"Thu nhập năm {(int)cmb.SelectedValue}";
            chart2.Titles.Add(title);
            LoadSoTienTheoNam((int)cmb.SelectedValue);
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            if (cmbNamCanXem.SelectedIndex == -1) return;
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
    }
}
