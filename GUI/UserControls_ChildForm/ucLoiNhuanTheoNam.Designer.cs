namespace GUI.UserControls_ChildForm
{
    partial class ucLoiNhuanTheoNam
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.chart2 = new DevExpress.XtraCharts.ChartControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNamCanXem = new System.Windows.Forms.ComboBox();
            this.btnExport2 = new DevExpress.XtraEditors.SimpleButton();
            this.sd2 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.chart2);
            this.panelControl3.Controls.Add(this.stackPanel2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(973, 578);
            this.panelControl3.TabIndex = 4;
            // 
            // chart2
            // 
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.Location = new System.Drawing.Point(2, 39);
            this.chart2.Name = "chart2";
            this.chart2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart2.Size = new System.Drawing.Size(969, 537);
            this.chart2.TabIndex = 1;
            chartTitle3.DXFont = new DevExpress.Drawing.DXFont("utm avo", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            chartTitle3.Text = "Thu nhập năm nay";
            this.chart2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.labelControl3);
            this.stackPanel2.Controls.Add(this.cmbNamCanXem);
            this.stackPanel2.Controls.Add(this.btnExport2);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel2.Location = new System.Drawing.Point(2, 2);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(969, 37);
            this.stackPanel2.TabIndex = 2;
            this.stackPanel2.UseSkinIndents = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Năm cần xem";
            // 
            // cmbNamCanXem
            // 
            this.cmbNamCanXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamCanXem.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.cmbNamCanXem.FormattingEnabled = true;
            this.cmbNamCanXem.Location = new System.Drawing.Point(127, 3);
            this.cmbNamCanXem.Name = "cmbNamCanXem";
            this.cmbNamCanXem.Size = new System.Drawing.Size(121, 30);
            this.cmbNamCanXem.TabIndex = 1;
            this.cmbNamCanXem.SelectedIndexChanged += new System.EventHandler(this.cmbNamCanXem_SelectedIndexChanged);
            // 
            // btnExport2
            // 
            this.btnExport2.Appearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnExport2.Appearance.Options.UseFont = true;
            this.btnExport2.Location = new System.Drawing.Point(252, 4);
            this.btnExport2.Name = "btnExport2";
            this.btnExport2.Size = new System.Drawing.Size(95, 29);
            this.btnExport2.TabIndex = 6;
            this.btnExport2.Text = "In thống kê";
            this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
            // 
            // sd2
            // 
            this.sd2.FileName = "xtraSaveFileDialog1";
            // 
            // ucLoiNhuanTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Name = "ucLoiNhuanTheoNam";
            this.Size = new System.Drawing.Size(973, 578);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraCharts.ChartControl chart2;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbNamCanXem;
        private DevExpress.XtraEditors.SimpleButton btnExport2;
        private DevExpress.XtraEditors.XtraSaveFileDialog sd2;
    }
}
