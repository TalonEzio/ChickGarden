namespace GUI.UserControls
{
    partial class frmChiTietPhieuNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuNhap));
            this.grCTPN = new DevExpress.XtraGrid.GridControl();
            this.grvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grCTPN
            // 
            this.grCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCTPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.grCTPN.Location = new System.Drawing.Point(0, 38);
            this.grCTPN.MainView = this.grvCTPN;
            this.grCTPN.Name = "grCTPN";
            this.grCTPN.Size = new System.Drawing.Size(800, 394);
            this.grCTPN.TabIndex = 0;
            this.grCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCTPN});
            // 
            // grvCTPN
            // 
            this.grvCTPN.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvCTPN.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvCTPN.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvCTPN.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.DetailTip.Options.UseFont = true;
            this.grvCTPN.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.Empty.Options.UseFont = true;
            this.grvCTPN.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.EvenRow.Options.UseFont = true;
            this.grvCTPN.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvCTPN.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FilterPanel.Options.UseFont = true;
            this.grvCTPN.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FixedLine.Options.UseFont = true;
            this.grvCTPN.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FocusedCell.Options.UseFont = true;
            this.grvCTPN.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FocusedRow.Options.UseFont = true;
            this.grvCTPN.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.FooterPanel.Options.UseFont = true;
            this.grvCTPN.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.GroupButton.Options.UseFont = true;
            this.grvCTPN.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.GroupFooter.Options.UseFont = true;
            this.grvCTPN.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.GroupPanel.Options.UseFont = true;
            this.grvCTPN.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.GroupRow.Options.UseFont = true;
            this.grvCTPN.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvCTPN.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvCTPN.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.HorzLine.Options.UseFont = true;
            this.grvCTPN.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvCTPN.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.OddRow.Options.UseFont = true;
            this.grvCTPN.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.Preview.Options.UseFont = true;
            this.grvCTPN.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.Row.Options.UseFont = true;
            this.grvCTPN.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.RowSeparator.Options.UseFont = true;
            this.grvCTPN.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.SelectedRow.Options.UseFont = true;
            this.grvCTPN.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.TopNewRow.Options.UseFont = true;
            this.grvCTPN.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.VertLine.Options.UseFont = true;
            this.grvCTPN.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.grvCTPN.Appearance.ViewCaption.Options.UseFont = true;
            this.grvCTPN.GridControl = this.grCTPN;
            this.grvCTPN.Name = "grvCTPN";
            this.grvCTPN.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCTPN_InitNewRow);
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnReload});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
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
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnDelete.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
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
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReload.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnReload.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReload.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnReload.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.btnReload.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // frmChiTietPhieuNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.grCTPN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.frmChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCTPN;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnReload;
    }
}