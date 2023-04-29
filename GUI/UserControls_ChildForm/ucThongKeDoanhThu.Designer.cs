namespace GUI.UserControls_ChildForm
{
    partial class ucThongKeDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart2 = new DevExpress.XtraCharts.ChartControl();
            this.chartTongDoanhThuNhomDoAn = new DevExpress.XtraCharts.ChartControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhThuNhomDoAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.tablePanel1.SetColumn(this.chart2, 0);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.Location = new System.Drawing.Point(13, 12);
            this.chart2.Name = "chart2";
            this.tablePanel1.SetRow(this.chart2, 0);
            this.chart2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart2.Size = new System.Drawing.Size(1041, 313);
            this.chart2.TabIndex = 1;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("utm avo", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle2.Text = "Thu nhập năm nay";
            this.chart2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // chartTongDoanhThuNhomDoAn
            // 
            this.tablePanel1.SetColumn(this.chartTongDoanhThuNhomDoAn, 0);
            this.chartTongDoanhThuNhomDoAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTongDoanhThuNhomDoAn.Location = new System.Drawing.Point(13, 329);
            this.chartTongDoanhThuNhomDoAn.Name = "chartTongDoanhThuNhomDoAn";
            this.tablePanel1.SetRow(this.chartTongDoanhThuNhomDoAn, 1);
            this.chartTongDoanhThuNhomDoAn.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartTongDoanhThuNhomDoAn.Size = new System.Drawing.Size(1041, 298);
            this.chartTongDoanhThuNhomDoAn.TabIndex = 0;
            chartTitle1.DXFont = new DevExpress.Drawing.DXFont("utm avo", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle1.Indent = 3;
            chartTitle1.Text = "Doanh Thu Tháng Này";
            this.chartTongDoanhThuNhomDoAn.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.9F)});
            this.tablePanel1.Controls.Add(this.chart2);
            this.tablePanel1.Controls.Add(this.chartTongDoanhThuNhomDoAn);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 317F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1067, 640);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // ucThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ucThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1067, 640);
            this.Load += new System.EventHandler(this.ucThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTongDoanhThuNhomDoAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chart2;
        private DevExpress.XtraCharts.ChartControl chartTongDoanhThuNhomDoAn;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}
