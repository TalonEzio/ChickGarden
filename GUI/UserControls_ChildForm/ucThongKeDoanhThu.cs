using BLL;
using DevExpress.Office.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Data;

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

        private void Btn_Click(object sender, EventArgs e)
        {
            LoadDoanhThuTheoLoaiDoAnThangNay();
            LoadSoTienTrongNam();
        }

        internal Button btn = new Button();
        void LoadDoanhThuTheoLoaiDoAnThangNay()
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeDoanhThuTheoNhomDoAnThangNay();
            if (dt.Rows.Count == 0) return;
            chartTongDoanhThuNhomDoAn.Series.Clear();

            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Loại đồ ăn", DevExpress.XtraCharts.ViewType.Bar);

            foreach (DataRow dr in dt.Rows)
            {
                series.Points.Add(
                    new DevExpress.XtraCharts.SeriesPoint(
                        dr[0].ToString(),
                        double.Parse(dr[1].ToString())));
            }
            series.Label.TextPattern = "{A}: {VP:P0}";
            chartTongDoanhThuNhomDoAn.Series.Add(series);
        }
        DevExpress.XtraCharts.Series ThuTien()
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeDoanhThuNamNay();
            if (dt.Rows.Count == 0) return null;
            chart2.Series.Clear();
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Doanh thu", DevExpress.XtraCharts.ViewType.Area);

            foreach (DataRow dr in dt.Rows)
            {
                double doanhThu = double.Parse(dr[1].ToString());
                if (doanhThu == 0) continue;
                series.Points.Add(
                    new DevExpress.XtraCharts.SeriesPoint(
                        dr[0].ToString(), doanhThu
                       ));
            }
            series.Label.TextPattern = "{A}: {VP:P0}";
            return series;
        }

        Series ChiTien()
        {
            DataTable dt = ThongKeBLL.Instance.ThongKeChiTieuNamNay();
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
            series.Label.TextPattern = "{A}: {VP:P0}";
            return series;
        }
        void LoadSoTienTrongNam()
        {
            DevExpress.XtraCharts.Series series1 = ThuTien();
            DevExpress.XtraCharts.Series series2 = ChiTien();
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);

        }


        private void ucThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            btn.PerformClick();
        }

    }
}
