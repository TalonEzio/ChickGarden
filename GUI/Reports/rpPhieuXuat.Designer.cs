namespace GUI.Reports
{
    partial class rpPhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpPhieuXuat));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblDoAn = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSoLuong = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDonGia = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.vendorTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorCountryRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblTenNV = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerContactNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblTenKH = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.invoiceInfoTable = new DevExpress.XtraReports.UI.XRTable();
            this.invoiceNumberRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDateRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblNgayBan = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceTotalTable = new DevExpress.XtraReports.UI.XRTable();
            this.invoiceTotalTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.total2Caption = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceTotalTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblTongTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.vendorLogo2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.vendorContactsTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorContactsRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorEmail = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorContactsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 37.62502F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailTable
            // 
            this.detailTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00007F, 2.62502F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow1});
            this.detailTable.SizeF = new System.Drawing.SizeF(470.9999F, 35F);
            this.detailTable.StylePriority.UseBorderColor = false;
            this.detailTable.StylePriority.UseBorders = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow1
            // 
            this.detailTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblDoAn,
            this.lblSoLuong,
            this.lblDonGia,
            this.lblTien});
            this.detailTableRow1.Name = "detailTableRow1";
            this.detailTableRow1.Weight = 10.58D;
            // 
            // lblDoAn
            // 
            this.lblDoAn.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDoAn.Font = new DevExpress.Drawing.DXFont("UTM Avo", 10F);
            this.lblDoAn.Name = "lblDoAn";
            this.lblDoAn.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 5, 0, 100F);
            this.lblDoAn.StylePriority.UseBackColor = false;
            this.lblDoAn.StylePriority.UseBorders = false;
            this.lblDoAn.StylePriority.UseFont = false;
            this.lblDoAn.StylePriority.UsePadding = false;
            this.lblDoAn.StylePriority.UseTextAlignment = false;
            this.lblDoAn.Text = "ProductName";
            this.lblDoAn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDoAn.Weight = 0.62056432917042836D;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new DevExpress.Drawing.DXFont("UTM Avo", 10F);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lblSoLuong.RowSpan = 2;
            this.lblSoLuong.StylePriority.UseBackColor = false;
            this.lblSoLuong.StylePriority.UseBorders = false;
            this.lblSoLuong.StylePriority.UseFont = false;
            this.lblSoLuong.StylePriority.UsePadding = false;
            this.lblSoLuong.StylePriority.UseTextAlignment = false;
            this.lblSoLuong.Text = "1";
            this.lblSoLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblSoLuong.Weight = 0.23038749526476512D;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new DevExpress.Drawing.DXFont("UTM Avo", 10F);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lblDonGia.RowSpan = 2;
            this.lblDonGia.StylePriority.UseBackColor = false;
            this.lblDonGia.StylePriority.UseBorders = false;
            this.lblDonGia.StylePriority.UseFont = false;
            this.lblDonGia.StylePriority.UsePadding = false;
            this.lblDonGia.StylePriority.UseTextAlignment = false;
            this.lblDonGia.Text = "0,00 ₫";
            this.lblDonGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblDonGia.TextFormatString = "{0:0.00 ₫}";
            this.lblDonGia.Weight = 0.26753095150666445D;
            // 
            // lblTien
            // 
            this.lblTien.Font = new DevExpress.Drawing.DXFont("UTM Avo", 10F);
            this.lblTien.Name = "lblTien";
            this.lblTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lblTien.RowSpan = 2;
            this.lblTien.StylePriority.UseBackColor = false;
            this.lblTien.StylePriority.UseBorders = false;
            this.lblTien.StylePriority.UseFont = false;
            this.lblTien.StylePriority.UseForeColor = false;
            this.lblTien.StylePriority.UsePadding = false;
            this.lblTien.StylePriority.UseTextAlignment = false;
            this.lblTien.Text = "0,00 ₫";
            this.lblTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblTien.TextFormatString = "{0:0.00 ₫}";
            this.lblTien.Weight = 0.23940863098186715D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 165.8333F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            this.GroupHeader2.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // xrPanel1
            // 
            this.xrPanel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorTable,
            this.customerTable,
            this.vendorLogo});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(491F, 165.8333F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            // 
            // vendorTable
            // 
            this.vendorTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 99.99997F);
            this.vendorTable.Name = "vendorTable";
            this.vendorTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorNameRow,
            this.vendorCountryRow});
            this.vendorTable.SizeF = new System.Drawing.SizeF(255F, 50F);
            // 
            // vendorNameRow
            // 
            this.vendorNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorName});
            this.vendorNameRow.Name = "vendorNameRow";
            this.vendorNameRow.Weight = 0.87272678379915458D;
            // 
            // vendorName
            // 
            this.vendorName.Font = new DevExpress.Drawing.DXFont("utm avo", 14F);
            this.vendorName.Name = "vendorName";
            this.vendorName.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F);
            this.vendorName.StylePriority.UseFont = false;
            this.vendorName.StylePriority.UsePadding = false;
            this.vendorName.StylePriority.UseTextAlignment = false;
            this.vendorName.Text = "Người tạo hóa đơn";
            this.vendorName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vendorName.Weight = 1D;
            // 
            // vendorCountryRow
            // 
            this.vendorCountryRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblTenNV});
            this.vendorCountryRow.Name = "vendorCountryRow";
            this.vendorCountryRow.Weight = 0.58181797116959633D;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Font = new DevExpress.Drawing.DXFont("utm avo", 10F);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F);
            this.lblTenNV.StylePriority.UseFont = false;
            this.lblTenNV.StylePriority.UsePadding = false;
            this.lblTenNV.StylePriority.UseTextAlignment = false;
            this.lblTenNV.Text = "VendorCountry";
            this.lblTenNV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblTenNV.Weight = 1D;
            // 
            // customerTable
            // 
            this.customerTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(226F, 99.99997F);
            this.customerTable.Name = "customerTable";
            this.customerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.customerNameRow,
            this.customerContactNameRow});
            this.customerTable.SizeF = new System.Drawing.SizeF(248.9999F, 50F);
            // 
            // customerNameRow
            // 
            this.customerNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerName});
            this.customerNameRow.Name = "customerNameRow";
            this.customerNameRow.Weight = 0.87272687850147868D;
            // 
            // customerName
            // 
            this.customerName.CanShrink = true;
            this.customerName.Font = new DevExpress.Drawing.DXFont("utm avo", 14F);
            this.customerName.Name = "customerName";
            this.customerName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 20, 0, 0, 100F);
            this.customerName.StylePriority.UseFont = false;
            this.customerName.StylePriority.UsePadding = false;
            this.customerName.StylePriority.UseTextAlignment = false;
            this.customerName.Text = "Người nhận";
            this.customerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.customerName.Weight = 1.3674163189595685D;
            // 
            // customerContactNameRow
            // 
            this.customerContactNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblTenKH});
            this.customerContactNameRow.Name = "customerContactNameRow";
            this.customerContactNameRow.Weight = 0.58181797314197325D;
            // 
            // lblTenKH
            // 
            this.lblTenKH.CanShrink = true;
            this.lblTenKH.Font = new DevExpress.Drawing.DXFont("utm avo", 10F);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 20, 0, 0, 100F);
            this.lblTenKH.StylePriority.UseFont = false;
            this.lblTenKH.StylePriority.UsePadding = false;
            this.lblTenKH.StylePriority.UseTextAlignment = false;
            this.lblTenKH.Text = "CustomerContactName";
            this.lblTenKH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblTenKH.Weight = 1.3674163189595685D;
            // 
            // vendorLogo
            // 
            this.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.vendorLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo.ImageSource"));
            this.vendorLogo.LocationFloat = new DevExpress.Utils.PointFloat(135.4957F, 10.00001F);
            this.vendorLogo.Name = "vendorLogo";
            this.vendorLogo.SizeF = new System.Drawing.SizeF(241.9583F, 68.29166F);
            this.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo.StylePriority.UseBorderColor = false;
            this.vendorLogo.StylePriority.UseBorders = false;
            this.vendorLogo.StylePriority.UsePadding = false;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.SubBand1.HeightF = 88.125F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrPanel2
            // 
            this.xrPanel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceInfoTable,
            this.invoiceTotalTable});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(491F, 88.125F);
            this.xrPanel2.StylePriority.UseBackColor = false;
            // 
            // invoiceInfoTable
            // 
            this.invoiceInfoTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.invoiceInfoTable.Name = "invoiceInfoTable";
            this.invoiceInfoTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.invoiceNumberRow,
            this.invoiceDateRow});
            this.invoiceInfoTable.SizeF = new System.Drawing.SizeF(255F, 67.48F);
            // 
            // invoiceNumberRow
            // 
            this.invoiceNumberRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceNumber});
            this.invoiceNumberRow.Name = "invoiceNumberRow";
            this.invoiceNumberRow.Weight = 0.76137257033012162D;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.CanGrow = false;
            this.invoiceNumber.Font = new DevExpress.Drawing.DXFont("utm avo", 16F);
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F);
            this.invoiceNumber.StylePriority.UseFont = false;
            this.invoiceNumber.StylePriority.UsePadding = false;
            this.invoiceNumber.StylePriority.UseTextAlignment = false;
            this.invoiceNumber.Text = "Ngày tạo";
            this.invoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceNumber.TextFormatString = "Invoice / {0}";
            this.invoiceNumber.Weight = 0.912698488401723D;
            // 
            // invoiceDateRow
            // 
            this.invoiceDateRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblNgayBan});
            this.invoiceDateRow.Name = "invoiceDateRow";
            this.invoiceDateRow.Weight = 0.72209877320573135D;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.CanGrow = false;
            this.lblNgayBan.Font = new DevExpress.Drawing.DXFont("utm avo", 12F);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F);
            this.lblNgayBan.StylePriority.UseFont = false;
            this.lblNgayBan.StylePriority.UsePadding = false;
            this.lblNgayBan.StylePriority.UseTextAlignment = false;
            this.lblNgayBan.Text = "InvoiceDate";
            this.lblNgayBan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblNgayBan.TextFormatString = "{0:dd/MM/yyyy}";
            this.lblNgayBan.Weight = 0.912698488401723D;
            // 
            // invoiceTotalTable
            // 
            this.invoiceTotalTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.invoiceTotalTable.LocationFloat = new DevExpress.Utils.PointFloat(276.6248F, 0F);
            this.invoiceTotalTable.Name = "invoiceTotalTable";
            this.invoiceTotalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.invoiceTotalTableRow1,
            this.invoiceTotalTableRow2});
            this.invoiceTotalTable.SizeF = new System.Drawing.SizeF(198.3751F, 88.125F);
            // 
            // invoiceTotalTableRow1
            // 
            this.invoiceTotalTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.total2Caption});
            this.invoiceTotalTableRow1.Name = "invoiceTotalTableRow1";
            this.invoiceTotalTableRow1.Weight = 0.7035148404875603D;
            // 
            // total2Caption
            // 
            this.total2Caption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.total2Caption.Font = new DevExpress.Drawing.DXFont("utm avo", 14F);
            this.total2Caption.ForeColor = System.Drawing.Color.White;
            this.total2Caption.Name = "total2Caption";
            this.total2Caption.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 10, 0, 100F);
            this.total2Caption.StylePriority.UseBackColor = false;
            this.total2Caption.StylePriority.UseFont = false;
            this.total2Caption.StylePriority.UseForeColor = false;
            this.total2Caption.StylePriority.UsePadding = false;
            this.total2Caption.StylePriority.UseTextAlignment = false;
            this.total2Caption.Text = "TỔNG THANH TOÁN";
            this.total2Caption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.total2Caption.Weight = 1D;
            // 
            // invoiceTotalTableRow2
            // 
            this.invoiceTotalTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblTongTien});
            this.invoiceTotalTableRow2.Name = "invoiceTotalTableRow2";
            this.invoiceTotalTableRow2.Weight = 0.68552131627384161D;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lblTongTien.Font = new DevExpress.Drawing.DXFont("utm avo", 20F);
            this.lblTongTien.ForeColor = System.Drawing.Color.White;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 5, 100F);
            this.lblTongTien.StylePriority.UseBackColor = false;
            this.lblTongTien.StylePriority.UseFont = false;
            this.lblTongTien.StylePriority.UseForeColor = false;
            this.lblTongTien.StylePriority.UsePadding = false;
            this.lblTongTien.StylePriority.UseTextAlignment = false;
            this.lblTongTien.Text = "0,00 ₫";
            this.lblTongTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.lblTongTien.TextFormatString = "{0:$0.00}";
            this.lblTongTien.Weight = 1D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorLogo2,
            this.vendorContactsTable});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 59.87498F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // vendorLogo2
            // 
            this.vendorLogo2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight;
            this.vendorLogo2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo2.ImageSource"));
            this.vendorLogo2.LocationFloat = new DevExpress.Utils.PointFloat(424.6252F, 9.999974F);
            this.vendorLogo2.Name = "vendorLogo2";
            this.vendorLogo2.SizeF = new System.Drawing.SizeF(54.37488F, 44.58332F);
            this.vendorLogo2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo2.StylePriority.UseBorderColor = false;
            this.vendorLogo2.StylePriority.UseBorders = false;
            this.vendorLogo2.StylePriority.UsePadding = false;
            // 
            // vendorContactsTable
            // 
            this.vendorContactsTable.BorderColor = System.Drawing.Color.Gray;
            this.vendorContactsTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.75F);
            this.vendorContactsTable.LocationFloat = new DevExpress.Utils.PointFloat(54.1667F, 9.999911F);
            this.vendorContactsTable.Name = "vendorContactsTable";
            this.vendorContactsTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.vendorContactsTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorContactsRow});
            this.vendorContactsTable.SizeF = new System.Drawing.SizeF(396.9999F, 44.58339F);
            this.vendorContactsTable.StylePriority.UseBorderColor = false;
            this.vendorContactsTable.StylePriority.UseFont = false;
            this.vendorContactsTable.StylePriority.UsePadding = false;
            // 
            // vendorContactsRow
            // 
            this.vendorContactsRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorEmail});
            this.vendorContactsRow.Name = "vendorContactsRow";
            this.vendorContactsRow.Weight = 1D;
            // 
            // vendorEmail
            // 
            this.vendorEmail.Font = new DevExpress.Drawing.DXFont("utm avo", 14F);
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.StylePriority.UseBorders = false;
            this.vendorEmail.StylePriority.UseFont = false;
            this.vendorEmail.StylePriority.UseTextAlignment = false;
            this.vendorEmail.Text = "Tươi từ chuồng gà đến đĩa của bạn";
            this.vendorEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vendorEmail.Weight = 1.47037036899627D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.GroupHeader1.HeightF = 45F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // xrPanel3
            // 
            this.xrPanel3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(491F, 35F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            // 
            // headerTable
            // 
            this.headerTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(471F, 35F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productNameCaption,
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Font = new DevExpress.Drawing.DXFont("UTM Avo", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100F);
            this.productNameCaption.StylePriority.UseBackColor = false;
            this.productNameCaption.StylePriority.UseFont = false;
            this.productNameCaption.StylePriority.UseForeColor = false;
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.StylePriority.UseTextAlignment = false;
            this.productNameCaption.Text = "Đồ ăn";
            this.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productNameCaption.Weight = 0.54299576076926437D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Font = new DevExpress.Drawing.DXFont("UTM Avo", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseBackColor = false;
            this.quantityCaption.StylePriority.UseFont = false;
            this.quantityCaption.StylePriority.UseForeColor = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Số Lượng";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.quantityCaption.Weight = 0.20158987455552396D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.BorderColor = System.Drawing.Color.White;
            this.unitPriceCaption.Font = new DevExpress.Drawing.DXFont("UTM Avo", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseBackColor = false;
            this.unitPriceCaption.StylePriority.UseBorderColor = false;
            this.unitPriceCaption.StylePriority.UseBorders = false;
            this.unitPriceCaption.StylePriority.UseFont = false;
            this.unitPriceCaption.StylePriority.UseForeColor = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "Đơn giá";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPriceCaption.Weight = 0.23409010635094937D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.BorderColor = System.Drawing.Color.White;
            this.lineTotalCaption.Font = new DevExpress.Drawing.DXFont("UTM Avo", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseBackColor = false;
            this.lineTotalCaption.StylePriority.UseBorderColor = false;
            this.lineTotalCaption.StylePriority.UseBorders = false;
            this.lineTotalCaption.StylePriority.UseFont = false;
            this.lineTotalCaption.StylePriority.UseForeColor = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "Tổng tiền";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotalCaption.Weight = 0.20948342029148717D;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // rpPhieuXuat
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(157F, 202F, 0F, 0F);
            this.PageColor = System.Drawing.Color.Transparent;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTotalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorContactsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell lblDoAn;
        private DevExpress.XtraReports.UI.XRTableCell lblSoLuong;
        private DevExpress.XtraReports.UI.XRTableCell lblDonGia;
        private DevExpress.XtraReports.UI.XRTableCell lblTien;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable vendorContactsTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorContactsRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorEmail;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRTable vendorTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorNameRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorName;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableRow customerContactNameRow;
        private DevExpress.XtraReports.UI.XRTableCell lblTenKH;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRTable invoiceInfoTable;
        private DevExpress.XtraReports.UI.XRTableRow invoiceNumberRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceNumber;
        private DevExpress.XtraReports.UI.XRTableRow invoiceDateRow;
        private DevExpress.XtraReports.UI.XRTableCell lblNgayBan;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRTableRow vendorCountryRow;
        private DevExpress.XtraReports.UI.XRTableCell lblTenNV;
        private DevExpress.XtraReports.UI.XRTable invoiceTotalTable;
        private DevExpress.XtraReports.UI.XRTableRow invoiceTotalTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell total2Caption;
        private DevExpress.XtraReports.UI.XRTableRow invoiceTotalTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell lblTongTien;
    }
}
