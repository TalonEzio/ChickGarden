﻿namespace GUI.UserControls
{
    partial class ucThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongTinCaNhan));
            this.grbTTCN = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.stkNgaySinh = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.stackPanel4 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.txtQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grbTTCN)).BeginInit();
            this.grbTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkNgaySinh)).BeginInit();
            this.stkNgaySinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).BeginInit();
            this.stackPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTCN
            // 
            this.grbTTCN.AppearanceCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grbTTCN.AppearanceCaption.Options.UseFont = true;
            this.grbTTCN.Controls.Add(this.stackPanel1);
            this.grbTTCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTCN.Location = new System.Drawing.Point(0, 0);
            this.grbTTCN.Name = "grbTTCN";
            this.grbTTCN.Size = new System.Drawing.Size(500, 520);
            this.grbTTCN.TabIndex = 1;
            this.grbTTCN.Text = "Thông tin cá nhân";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.txtHoTen);
            this.stackPanel1.Controls.Add(this.stkNgaySinh);
            this.stackPanel1.Controls.Add(this.stackPanel4);
            this.stackPanel1.Controls.Add(this.txtQueQuan);
            this.stackPanel1.Controls.Add(this.txtSoDienThoai);
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(2, 27);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(496, 491);
            this.stackPanel1.TabIndex = 15;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(51, 16);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(6);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.AdvancedModeOptions.Label = "Họ Tên";
            this.txtHoTen.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtHoTen.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.AutoHeight = false;
            this.txtHoTen.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtHoTen.Size = new System.Drawing.Size(394, 60);
            this.txtHoTen.TabIndex = 14;
            // 
            // stkNgaySinh
            // 
            this.stkNgaySinh.Controls.Add(this.labelControl1);
            this.stkNgaySinh.Controls.Add(this.dtpNgaySinh);
            this.stkNgaySinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.stkNgaySinh.Location = new System.Drawing.Point(42, 84);
            this.stkNgaySinh.Name = "stkNgaySinh";
            this.stkNgaySinh.Size = new System.Drawing.Size(411, 38);
            this.stkNgaySinh.TabIndex = 15;
            this.stkNgaySinh.UseSkinIndents = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpNgaySinh.EditValue = null;
            this.dtpNgaySinh.Location = new System.Drawing.Point(136, 3);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.dtpNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Size = new System.Drawing.Size(263, 32);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.labelControl2);
            this.stackPanel4.Controls.Add(this.rdoNam);
            this.stackPanel4.Controls.Add(this.rdoNu);
            this.stackPanel4.Controls.Add(this.rdoKhac);
            this.stackPanel4.Location = new System.Drawing.Point(40, 126);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(416, 36);
            this.stackPanel4.TabIndex = 16;
            this.stackPanel4.UseSkinIndents = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Giới tính";
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoNam.Location = new System.Drawing.Point(142, 3);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 30);
            this.rdoNam.TabIndex = 1;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoNu.Location = new System.Drawing.Point(221, 3);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(56, 30);
            this.rdoNu.TabIndex = 2;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoKhac.Location = new System.Drawing.Point(281, 3);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(78, 30);
            this.rdoKhac.TabIndex = 3;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.EditValue = "";
            this.txtQueQuan.Location = new System.Drawing.Point(50, 170);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(6);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Properties.AdvancedModeOptions.Label = "Quê quán";
            this.txtQueQuan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtQueQuan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtQueQuan.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtQueQuan.Properties.Appearance.Options.UseFont = true;
            this.txtQueQuan.Properties.AutoHeight = false;
            this.txtQueQuan.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtQueQuan.Size = new System.Drawing.Size(396, 61);
            this.txtQueQuan.TabIndex = 13;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(50, 239);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Properties.AdvancedModeOptions.Label = "Số điện thoại";
            this.txtSoDienThoai.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtSoDienThoai.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtSoDienThoai.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtSoDienThoai.Properties.Appearance.Options.UseFont = true;
            this.txtSoDienThoai.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtSoDienThoai.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtSoDienThoai.Properties.AutoHeight = false;
            this.txtSoDienThoai.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtSoDienThoai.Size = new System.Drawing.Size(396, 61);
            this.txtSoDienThoai.TabIndex = 17;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.btnCapNhat);
            this.stackPanel2.Controls.Add(this.btnXoaTaiKhoan);
            this.stackPanel2.Location = new System.Drawing.Point(43, 304);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(409, 140);
            this.stackPanel2.TabIndex = 18;
            this.stackPanel2.UseSkinIndents = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Location = new System.Drawing.Point(13, 41);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(188, 57);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnXoaTaiKhoan.Appearance.Options.UseFont = true;
            this.btnXoaTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTaiKhoan.ImageOptions.SvgImage")));
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(205, 41);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(188, 57);
            this.btnXoaTaiKhoan.TabIndex = 1;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ucThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbTTCN);
            this.Name = "ucThongTinCaNhan";
            this.Size = new System.Drawing.Size(500, 520);
            this.Load += new System.EventHandler(this.ucThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbTTCN)).EndInit();
            this.grbTTCN.ResumeLayout(false);
            this.grbTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkNgaySinh)).EndInit();
            this.stkNgaySinh.ResumeLayout(false);
            this.stkNgaySinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).EndInit();
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbTTCN;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.Utils.Layout.StackPanel stkNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private DevExpress.Utils.Layout.StackPanel stackPanel4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoKhac;
        private DevExpress.XtraEditors.TextEdit txtQueQuan;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoaTaiKhoan;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
    }
}
