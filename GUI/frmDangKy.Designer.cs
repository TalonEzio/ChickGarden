namespace GUI
{
    partial class frmDangKy
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
            this.grbTTCN = new DevExpress.XtraEditors.GroupControl();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.grbChucVu = new DevExpress.XtraEditors.GroupControl();
            this.leChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grbTTCN)).BeginInit();
            this.grbTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbChucVu)).BeginInit();
            this.grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTCN
            // 
            this.grbTTCN.AppearanceCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grbTTCN.AppearanceCaption.Options.UseFont = true;
            this.grbTTCN.Controls.Add(this.txtUsername);
            this.grbTTCN.Controls.Add(this.txtPassword);
            this.grbTTCN.Controls.Add(this.grbChucVu);
            this.grbTTCN.Controls.Add(this.txtSoDienThoai);
            this.grbTTCN.Controls.Add(this.txtQueQuan);
            this.grbTTCN.Controls.Add(this.stackPanel1);
            this.grbTTCN.Controls.Add(this.labelControl2);
            this.grbTTCN.Controls.Add(this.dtpNgaySinh);
            this.grbTTCN.Controls.Add(this.labelControl1);
            this.grbTTCN.Controls.Add(this.txtTen);
            this.grbTTCN.Controls.Add(this.txtHo);
            this.grbTTCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTTCN.Location = new System.Drawing.Point(0, 0);
            this.grbTTCN.Name = "grbTTCN";
            this.grbTTCN.Size = new System.Drawing.Size(456, 589);
            this.grbTTCN.TabIndex = 0;
            this.grbTTCN.Text = "Thông tin cá nhân";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(27, 350);
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
            this.txtSoDienThoai.Size = new System.Drawing.Size(186, 59);
            this.txtSoDienThoai.TabIndex = 10;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(27, 249);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Properties.AdvancedModeOptions.Label = "Quê quán";
            this.txtQueQuan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtQueQuan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtQueQuan.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtQueQuan.Properties.Appearance.Options.UseFont = true;
            this.txtQueQuan.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtQueQuan.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtQueQuan.Properties.AutoHeight = false;
            this.txtQueQuan.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtQueQuan.Size = new System.Drawing.Size(398, 70);
            this.txtQueQuan.TabIndex = 9;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.rdoNam);
            this.stackPanel1.Controls.Add(this.rdoNu);
            this.stackPanel1.Controls.Add(this.rdoKhac);
            this.stackPanel1.Location = new System.Drawing.Point(147, 177);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(243, 66);
            this.stackPanel1.TabIndex = 8;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoNam.Location = new System.Drawing.Point(13, 17);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 30);
            this.rdoNam.TabIndex = 5;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoNu.Location = new System.Drawing.Point(92, 17);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(56, 30);
            this.rdoNu.TabIndex = 7;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.rdoKhac.Location = new System.Drawing.Point(152, 17);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(78, 30);
            this.rdoKhac.TabIndex = 6;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 193);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 26);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.EditValue = null;
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 130);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.dtpNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Size = new System.Drawing.Size(169, 32);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 26);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(239, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.AdvancedModeOptions.Label = "Tên";
            this.txtTen.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtTen.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtTen.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTen.Properties.AutoHeight = false;
            this.txtTen.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtTen.Size = new System.Drawing.Size(186, 57);
            this.txtTen.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(27, 41);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.AdvancedModeOptions.Label = "Họ";
            this.txtHo.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtHo.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtHo.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtHo.Properties.AutoHeight = false;
            this.txtHo.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtHo.Size = new System.Drawing.Size(186, 58);
            this.txtHo.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLamLai);
            this.panelControl1.Controls.Add(this.btnDangKy);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 589);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(456, 72);
            this.panelControl1.TabIndex = 1;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnLamLai.Appearance.Options.UseFont = true;
            this.btnLamLai.Location = new System.Drawing.Point(259, 16);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(131, 46);
            this.btnLamLai.TabIndex = 1;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDangKy.Appearance.Options.UseFont = true;
            this.btnDangKy.Location = new System.Drawing.Point(45, 16);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(131, 46);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // grbChucVu
            // 
            this.grbChucVu.AppearanceCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grbChucVu.AppearanceCaption.Options.UseFont = true;
            this.grbChucVu.Controls.Add(this.leChucVu);
            this.grbChucVu.Location = new System.Drawing.Point(225, 350);
            this.grbChucVu.Name = "grbChucVu";
            this.grbChucVu.Size = new System.Drawing.Size(200, 61);
            this.grbChucVu.TabIndex = 12;
            this.grbChucVu.Text = "Chức Vụ";
            // 
            // leChucVu
            // 
            this.leChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leChucVu.Location = new System.Drawing.Point(2, 27);
            this.leChucVu.Name = "leChucVu";
            this.leChucVu.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.leChucVu.Properties.Appearance.Options.UseFont = true;
            this.leChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leChucVu.Size = new System.Drawing.Size(196, 32);
            this.leChucVu.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(27, 420);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AdvancedModeOptions.Label = "Tài khoản";
            this.txtUsername.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtUsername.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.AutoHeight = false;
            this.txtUsername.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsername.Size = new System.Drawing.Size(396, 61);
            this.txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(27, 506);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AdvancedModeOptions.Label = "Mật khẩu";
            this.txtPassword.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtPassword.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(396, 61);
            this.txtPassword.TabIndex = 13;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 661);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grbTTCN);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangKy_FormClosing);
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbTTCN)).EndInit();
            this.grbTTCN.ResumeLayout(false);
            this.grbTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbChucVu)).EndInit();
            this.grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbTTCN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoKhac;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.TextEdit txtQueQuan;
        private DevExpress.XtraEditors.GroupControl grbChucVu;
        private DevExpress.XtraEditors.LookUpEdit leChucVu;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
    }
}