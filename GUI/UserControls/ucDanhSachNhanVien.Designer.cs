namespace GUI.UserControls
{
    partial class ucDanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachNhanVien));
            this.grDSNV = new DevExpress.XtraGrid.GridControl();
            this.grvDSNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sdExcel = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grDSNV
            // 
            this.grDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSNV.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grDSNV.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grDSNV.Location = new System.Drawing.Point(0, 38);
            this.grDSNV.MainView = this.grvDSNV;
            this.grDSNV.Name = "grDSNV";
            this.grDSNV.Size = new System.Drawing.Size(758, 345);
            this.grDSNV.TabIndex = 14;
            this.grDSNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDSNV});
            // 
            // grvDSNV
            // 
            this.grvDSNV.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDSNV.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDSNV.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDSNV.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.DetailTip.Options.UseFont = true;
            this.grvDSNV.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.Empty.Options.UseFont = true;
            this.grvDSNV.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.EvenRow.Options.UseFont = true;
            this.grvDSNV.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDSNV.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDSNV.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FixedLine.Options.UseFont = true;
            this.grvDSNV.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDSNV.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDSNV.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDSNV.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.GroupButton.Options.UseFont = true;
            this.grvDSNV.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDSNV.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDSNV.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.GroupRow.Options.UseFont = true;
            this.grvDSNV.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDSNV.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDSNV.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.HorzLine.Options.UseFont = true;
            this.grvDSNV.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvDSNV.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.OddRow.Options.UseFont = true;
            this.grvDSNV.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.Preview.Options.UseFont = true;
            this.grvDSNV.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.Row.Options.UseFont = true;
            this.grvDSNV.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDSNV.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDSNV.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDSNV.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.VertLine.Options.UseFont = true;
            this.grvDSNV.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSNV.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDSNV.GridControl = this.grDSNV;
            this.grvDSNV.Name = "grvDSNV";
            this.grvDSNV.OptionsSelection.MultiSelect = true;
            this.grvDSNV.OptionsView.RowAutoHeight = true;
            this.grvDSNV.OptionsView.ShowFooter = true;
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
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("UTM Avo", 16F);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnReLoad,
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnExport});
            this.barManager1.MaxItemId = 15;
            this.barManager1.OptionsStubGlyphs.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.barManager1.OptionsStubGlyphs.UseFont = true;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(310, 127);
            this.bar1.FloatSize = new System.Drawing.Size(50, 0);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 10;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnAdd.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnAdd.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 12;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDelete.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Caption = "Tải lại";
            this.btnReLoad.Id = 9;
            this.btnReLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.ImageOptions.Image")));
            this.btnReLoad.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReLoad.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnReLoad.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnReLoad.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 11;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnSave.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSave.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSave.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnSave.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnSave.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Xuất file";
            this.btnExport.Id = 13;
            this.btnExport.ImageOptions.DisabledSvgImageSize = new System.Drawing.Size(30, 30);
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnExport.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnExport.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnExport.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExport.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnExport.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnExport.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnExport.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnExport.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnExport.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnExport.Name = "btnExport";
            this.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(758, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 383);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(758, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(758, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // sdExcel
            // 
            this.sdExcel.FileName = "xtraSaveFileDialog1";
            // 
            // ucDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grDSNV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ucDanhSachNhanVien";
            this.Size = new System.Drawing.Size(758, 403);
            this.Load += new System.EventHandler(this.ucDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grDSNV;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDSNV;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        internal DevExpress.XtraBars.BarButtonItem btnReLoad;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraEditors.XtraSaveFileDialog sdExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}
