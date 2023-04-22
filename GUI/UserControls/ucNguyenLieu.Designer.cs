namespace GUI.UserControls
{
    partial class ucNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNguyenLieu));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grDSNL = new DevExpress.XtraGrid.GridControl();
            this.grvDSNL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Lọc = new DevExpress.XtraEditors.LabelControl();
            this.stkButton = new DevExpress.Utils.Layout.StackPanel();
            this.cmbLoaiNguyenLieu = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDSNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkButton)).BeginInit();
            this.stkButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.grDSNL);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 54);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(851, 482);
            this.panelControl2.TabIndex = 8;
            // 
            // grDSNL
            // 
            this.grDSNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSNL.Location = new System.Drawing.Point(0, 0);
            this.grDSNL.MainView = this.grvDSNL;
            this.grDSNL.Name = "grDSNL";
            this.grDSNL.Size = new System.Drawing.Size(851, 482);
            this.grDSNL.TabIndex = 0;
            this.grDSNL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDSNL});
            // 
            // grvDSNL
            // 
            this.grvDSNL.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDSNL.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDSNL.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDSNL.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.DetailTip.Options.UseFont = true;
            this.grvDSNL.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.Empty.Options.UseFont = true;
            this.grvDSNL.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.EvenRow.Options.UseFont = true;
            this.grvDSNL.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDSNL.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDSNL.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FixedLine.Options.UseFont = true;
            this.grvDSNL.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDSNL.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDSNL.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDSNL.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.GroupButton.Options.UseFont = true;
            this.grvDSNL.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDSNL.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDSNL.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.GroupRow.Options.UseFont = true;
            this.grvDSNL.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDSNL.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDSNL.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.HorzLine.Options.UseFont = true;
            this.grvDSNL.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvDSNL.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.OddRow.Options.UseFont = true;
            this.grvDSNL.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.Preview.Options.UseFont = true;
            this.grvDSNL.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.Row.Options.UseFont = true;
            this.grvDSNL.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDSNL.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDSNL.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDSNL.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.VertLine.Options.UseFont = true;
            this.grvDSNL.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNL.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDSNL.GridControl = this.grDSNL;
            this.grvDSNL.Name = "grvDSNL";
            this.grvDSNL.OptionsSelection.MultiSelect = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(13, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(102, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.Size = new System.Drawing.Size(79, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.Appearance.Options.UseFont = true;
            this.btnReLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.ImageOptions.Image")));
            this.btnReLoad.Location = new System.Drawing.Point(185, 7);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReLoad.Size = new System.Drawing.Size(90, 39);
            this.btnReLoad.TabIndex = 3;
            this.btnReLoad.Text = "Tải lại";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(279, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSave.Size = new System.Drawing.Size(74, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Lọc
            // 
            this.Lọc.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.Lọc.Appearance.Options.UseFont = true;
            this.Lọc.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Lọc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Lọc.ImageOptions.Image")));
            this.Lọc.Location = new System.Drawing.Point(357, 10);
            this.Lọc.Name = "Lọc";
            this.Lọc.Size = new System.Drawing.Size(219, 34);
            this.Lọc.TabIndex = 6;
            this.Lọc.Text = "Lọc loại nguyên liệu";
            // 
            // stkButton
            // 
            this.stkButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.stkButton.Appearance.Options.UseBackColor = true;
            this.stkButton.Controls.Add(this.btnAdd);
            this.stkButton.Controls.Add(this.btnDelete);
            this.stkButton.Controls.Add(this.btnReLoad);
            this.stkButton.Controls.Add(this.btnSave);
            this.stkButton.Controls.Add(this.Lọc);
            this.stkButton.Controls.Add(this.cmbLoaiNguyenLieu);
            this.stkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stkButton.Location = new System.Drawing.Point(0, 0);
            this.stkButton.Name = "stkButton";
            this.stkButton.Size = new System.Drawing.Size(851, 54);
            this.stkButton.TabIndex = 0;
            this.stkButton.UseSkinIndents = true;
            // 
            // cmbLoaiNguyenLieu
            // 
            this.cmbLoaiNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiNguyenLieu.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.cmbLoaiNguyenLieu.FormattingEnabled = true;
            this.cmbLoaiNguyenLieu.Location = new System.Drawing.Point(580, 10);
            this.cmbLoaiNguyenLieu.Name = "cmbLoaiNguyenLieu";
            this.cmbLoaiNguyenLieu.Size = new System.Drawing.Size(121, 34);
            this.cmbLoaiNguyenLieu.TabIndex = 7;
            this.cmbLoaiNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiNguyenLieu_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.stkButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(851, 54);
            this.panelControl1.TabIndex = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(851, 0);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = null;
            this.barDockControl3.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 536);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Size = new System.Drawing.Size(851, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(851, 0);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // ucNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "ucNguyenLieu";
            this.Size = new System.Drawing.Size(851, 536);
            this.Load += new System.EventHandler(this.ucNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDSNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkButton)).EndInit();
            this.stkButton.ResumeLayout(false);
            this.stkButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grDSNL;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDSNL;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl Lọc;
        private DevExpress.Utils.Layout.StackPanel stkButton;
        private System.Windows.Forms.ComboBox cmbLoaiNguyenLieu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.Bar bar1;
    }
}
