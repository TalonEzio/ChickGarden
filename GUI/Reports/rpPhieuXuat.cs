using BLL;
using DevExpress.DataAccess.Native.Data;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Commands;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.Reports
{
    public partial class rpPhieuXuat : DevExpress.XtraReports.UI.XtraReport
    {
        System.Data.DataTable dt;
        public rpPhieuXuat(int maPhieuXuat)
        {
            InitializeComponent();
            this.DataSource = dt = PhieuXuatBLL.Instance.PhieuXuatDoAn(maPhieuXuat);
            ShowReport();

        }


        void ShowReport()
        {
            ShowHeader();
            ShowDetail();
        }
        void ShowHeader()
        {
            lblTenNV.DataBindings.Add("Text", dt, "HoTen");
            lblTenKH.DataBindings.Add("Text", dt, "TenKhachHang");
            lblNgayBan.DataBindings.Add("Text", dt, "NgayBan");

            double totalResult = 0;
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                totalResult += double.Parse(dr[6].ToString());
            }
            lblTongTien.Text = totalResult + " ₫";
        }
        void ShowDetail()
        {
            lblDoAn.DataBindings.Add("Text", dt, "TenDoAn");
            lblSoLuong.DataBindings.Add("Text", dt, "SoLuong");
            lblDonGia.DataBindings.Add("Text", dt, "DonGia");
            lblTien.DataBindings.Add("Text", dt, "TongTien");

        }
    }
}
