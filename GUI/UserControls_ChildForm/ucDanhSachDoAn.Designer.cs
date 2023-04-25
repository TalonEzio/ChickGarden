namespace GUI.UserControls
{
    partial class ucDanhSachDoAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachDoAn));
            this.grDSDA = new DevExpress.XtraGrid.GridControl();
            this.grvDSDA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.stkButton = new DevExpress.Utils.Layout.StackPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnReLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Lọc = new DevExpress.XtraEditors.LabelControl();
            this.cmbLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grDSDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stkButton)).BeginInit();
            this.stkButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSDA
            // 
            this.grDSDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSDA.Location = new System.Drawing.Point(0, 0);
            this.grDSDA.MainView = this.grvDSDA;
            this.grDSDA.Name = "grDSDA";
            this.grDSDA.Size = new System.Drawing.Size(786, 466);
            this.grDSDA.TabIndex = 0;
            this.grDSDA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDSDA});
            // 
            // grvDSDA
            // 
            this.grvDSDA.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDSDA.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDSDA.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDSDA.Appearance.DetailTip.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.DetailTip.Options.UseFont = true;
            this.grvDSDA.Appearance.Empty.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.Empty.Options.UseFont = true;
            this.grvDSDA.Appearance.EvenRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.EvenRow.Options.UseFont = true;
            this.grvDSDA.Appearance.FilterCloseButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDSDA.Appearance.FilterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDSDA.Appearance.FixedLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FixedLine.Options.UseFont = true;
            this.grvDSDA.Appearance.FocusedCell.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDSDA.Appearance.FocusedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDSDA.Appearance.FooterPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDSDA.Appearance.GroupButton.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.GroupButton.Options.UseFont = true;
            this.grvDSDA.Appearance.GroupFooter.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDSDA.Appearance.GroupPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDSDA.Appearance.GroupRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.GroupRow.Options.UseFont = true;
            this.grvDSDA.Appearance.HeaderPanel.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDSDA.Appearance.HideSelectionRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDSDA.Appearance.HorzLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.HorzLine.Options.UseFont = true;
            this.grvDSDA.Appearance.HotTrackedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.HotTrackedRow.Options.UseFont = true;
            this.grvDSDA.Appearance.OddRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.OddRow.Options.UseFont = true;
            this.grvDSDA.Appearance.Preview.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.Preview.Options.UseFont = true;
            this.grvDSDA.Appearance.Row.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.Row.Options.UseFont = true;
            this.grvDSDA.Appearance.RowSeparator.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDSDA.Appearance.SelectedRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDSDA.Appearance.TopNewRow.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDSDA.Appearance.VertLine.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.VertLine.Options.UseFont = true;
            this.grvDSDA.Appearance.ViewCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grvDSDA.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDSDA.GridControl = this.grDSDA;
            this.grvDSDA.Name = "grvDSDA";
            this.grvDSDA.OptionsSelection.MultiSelect = true;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(698, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 517);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Size = new System.Drawing.Size(698, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = null;
            this.barDockControl3.Size = new System.Drawing.Size(0, 517);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(698, 0);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Size = new System.Drawing.Size(0, 517);
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
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.stkButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(786, 54);
            this.panelControl1.TabIndex = 1;
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
            this.stkButton.Controls.Add(this.cmbLoaiDoAn);
            this.stkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stkButton.Location = new System.Drawing.Point(0, 0);
            this.stkButton.Name = "stkButton";
            this.stkButton.Size = new System.Drawing.Size(786, 54);
            this.stkButton.TabIndex = 0;
            this.stkButton.UseSkinIndents = true;
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
            this.Lọc.Size = new System.Drawing.Size(166, 34);
            this.Lọc.TabIndex = 6;
            this.Lọc.Text = "Lọc loại đồ ăn";
            // 
            // cmbLoaiDoAn
            // 
            this.cmbLoaiDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiDoAn.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.cmbLoaiDoAn.FormattingEnabled = true;
            this.cmbLoaiDoAn.Location = new System.Drawing.Point(527, 10);
            this.cmbLoaiDoAn.Name = "cmbLoaiDoAn";
            this.cmbLoaiDoAn.Size = new System.Drawing.Size(121, 34);
            this.cmbLoaiDoAn.TabIndex = 7;
            this.cmbLoaiDoAn.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiDoAn_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.grDSDA);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 54);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(786, 466);
            this.panelControl2.TabIndex = 2;
            // 
            // ucDanhSachDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDanhSachDoAn";
            this.Size = new System.Drawing.Size(786, 520);
            this.Load += new System.EventHandler(this.ucDanhSachDoAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDSDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stkButton)).EndInit();
            this.stkButton.ResumeLayout(false);
            this.stkButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grDSDA;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDSDA;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.StackPanel stkButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnReLoad;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl Lọc;
        private System.Windows.Forms.ComboBox cmbLoaiDoAn;
    }
}
