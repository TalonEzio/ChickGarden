using BLL;
using DevExpress.CodeParser;
using DevExpress.DataAccess.Native.Data;
using DevExpress.Diagram.Core.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Commands;
using DTO;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.Reports
{
    public partial class rpPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        NhaCungCap nhaCungCap;
        System.Data.DataTable dt;
        public rpPhieuNhap(NhaCungCap nhaCungCap)
        {
            InitializeComponent();
            this.nhaCungCap = nhaCungCap;
            dt = NhaCungCapBLL.Instance.PhieuNhapNguyenLieu(nhaCungCap.MaNCC);

            this.DataSource = dt;
            ShowInvoice();
        }

        void ShowInvoice()
        {
            ShowHeader();

            ShowDetail();
        }
        void ShowHeader()
        {
            lblTenNCC.Text = nhaCungCap.TenNCC;
            lblSDTNCC.Text = nhaCungCap.SoDienThoai;
            lblDCNCC.Text = nhaCungCap.DiaChi;

            lblNgayNhap.DataBindings.Add("Text", dt, "NgayNhap");
            lblTenNV.DataBindings.Add("Text", dt, "HoTen");
        }
        void ShowDetail()
        {
            lblTenNguyenLieu.DataBindings.Add("Text", dt, "TenNguyenLieu");
            lblSoLuong.DataBindings.Add("Text", dt, "SoLuong");
            lblDonGia.DataBindings.Add("Text", dt, "DonGia");
            lblThanhTien.DataBindings.Add("Text", dt, "TongTien");

            double totalResult = 0;
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                totalResult += int.Parse(dr[1].ToString()) * double.Parse(dr[2].ToString());
            }
            lblTongTien.Text = totalResult + " ₫";
        }

    }
}
