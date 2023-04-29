namespace GUI.UserControls_ChildForm
{
    partial class ucPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuXuat));
            this.grPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.grvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grPhieuXuat
            // 
            this.grPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPhieuXuat.Location = new System.Drawing.Point(0, 38);
            this.grPhieuXuat.MainView = this.grvPhieuXuat;
            this.grPhieuXuat.Name = "grPhieuXuat";
            this.grPhieuXuat.Size = new System.Drawing.Size(877, 496);
            this.grPhieuXuat.TabIndex = 0;
            this.grPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuXuat});
            // 
            // grvPhieuXuat
            // 
            this.grvPhieuXuat.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.DetailTip.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.Empty.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.EvenRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FilterPanel.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FixedLine.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FocusedCell.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FocusedRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.FooterPanel.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.GroupButton.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.GroupFooter.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.GroupPanel.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.GroupRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.HorzLine.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.OddRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.Preview.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.Row.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.RowSeparator.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.SelectedRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.TopNewRow.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.VertLine.Options.UseFont = true;
            this.grvPhieuXuat.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvPhieuXuat.Appearance.ViewCaption.Options.UseFont = true;
            this.grvPhieuXuat.GridControl = this.grPhieuXuat;
            this.grvPhieuXuat.Name = "grvPhieuXuat";
            this.grvPhieuXuat.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvPhieuXuat_InitNewRow);
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDetail,
            this.btnSave,
            this.btnReLoad,
            this.btnReport});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetail),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReport)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm hóa đơn mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnAdd.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Xem chi tiết";
            this.btnDetail.Id = 1;
            this.btnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.Image")));
            this.btnDetail.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDetail.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDetail.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDetail.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDetail.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnDetail.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnDetail.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDetail.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDetail.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu thay đổi";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnSave.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSave.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSave.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnSave.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Caption = "Tải lại";
            this.btnReLoad.Id = 3;
            this.btnReLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.ImageOptions.Image")));
            this.btnReLoad.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReLoad.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReLoad_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Xuất hóa đơn";
            this.btnReport.Id = 4;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReport.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnReport.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReport.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnReport.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnReport.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnReport.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnReport.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReport.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnReport.Name = "btnReport";
            this.btnReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(877, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(877, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(877, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // ucPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grPhieuXuat);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPhieuXuat";
            this.Size = new System.Drawing.Size(877, 534);
            this.Load += new System.EventHandler(this.ucPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhieuXuat;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        internal DevExpress.XtraBars.BarButtonItem btnReLoad;
        private DevExpress.XtraBars.BarButtonItem btnReport;
    }
}
