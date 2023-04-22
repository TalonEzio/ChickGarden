namespace GUI.UserControls
{
    partial class ucPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuNhap));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grDSPN = new DevExpress.XtraGrid.GridControl();
            this.grvDSPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // grDSPN
            // 
            this.grDSPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSPN.Location = new System.Drawing.Point(0, 38);
            this.grDSPN.MainView = this.grvDSPN;
            this.grDSPN.Name = "grDSPN";
            this.grDSPN.Size = new System.Drawing.Size(927, 458);
            this.grDSPN.TabIndex = 0;
            this.grDSPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDSPN});
            // 
            // grvDSPN
            // 
            this.grvDSPN.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDSPN.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDSPN.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDSPN.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.DetailTip.Options.UseFont = true;
            this.grvDSPN.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.Empty.Options.UseFont = true;
            this.grvDSPN.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.EvenRow.Options.UseFont = true;
            this.grvDSPN.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDSPN.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDSPN.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FixedLine.Options.UseFont = true;
            this.grvDSPN.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDSPN.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDSPN.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDSPN.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.GroupButton.Options.UseFont = true;
            this.grvDSPN.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDSPN.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDSPN.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.GroupRow.Options.UseFont = true;
            this.grvDSPN.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDSPN.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDSPN.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.HorzLine.Options.UseFont = true;
            this.grvDSPN.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvDSPN.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.OddRow.Options.UseFont = true;
            this.grvDSPN.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.Preview.Options.UseFont = true;
            this.grvDSPN.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.Row.Options.UseFont = true;
            this.grvDSPN.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDSPN.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDSPN.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDSPN.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.VertLine.Options.UseFont = true;
            this.grvDSPN.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSPN.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDSPN.GridControl = this.grDSPN;
            this.grvDSPN.Name = "grvDSPN";
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Phiếu nhập bạn đã tạo";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xuất Excel";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem2.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem2.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm phiếu nhập mới";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem3.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.barButtonItem3.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(927, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(927, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(927, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // ucPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grDSPN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPhieuNhap";
            this.Size = new System.Drawing.Size(927, 516);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grDSPN;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDSPN;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}
