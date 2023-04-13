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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSuaNhanVien,
            this.btnXoa});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(204, 138);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaNhanVien),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm nhân viên";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnThem.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnThem.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThem.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnThem.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnThem.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnThem.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnThem.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnThem.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Caption = "Sửa thông tin";
            this.btnSuaNhanVien.Id = 2;
            this.btnSuaNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNhanVien.ImageOptions.SvgImage")));
            this.btnSuaNhanVien.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnSuaNhanVien.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSuaNhanVien.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSuaNhanVien.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSuaNhanVien.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnSuaNhanVien.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnSuaNhanVien.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnSuaNhanVien.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnSuaNhanVien.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(738, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa nhân viên";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.ItemAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnXoa.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btnXoa.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnXoa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnXoa.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.btnXoa.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ucDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ucDanhSachNhanVien";
            this.Size = new System.Drawing.Size(738, 483);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSuaNhanVien;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
    }
}
