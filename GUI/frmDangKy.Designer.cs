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
            this.grbChucVu = new DevExpress.XtraEditors.GroupControl();
            this.leChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grbTTCN)).BeginInit();
            this.grbTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbChucVu)).BeginInit();
            this.grbChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTCN
            // 
            this.grbTTCN.AppearanceCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grbTTCN.AppearanceCaption.Options.UseFont = true;
            this.grbTTCN.Controls.Add(this.stackPanel1);
            this.grbTTCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTTCN.Location = new System.Drawing.Point(0, 0);
            this.grbTTCN.Name = "grbTTCN";
            this.grbTTCN.Size = new System.Drawing.Size(437, 271);
            this.grbTTCN.TabIndex = 0;
            this.grbTTCN.Text = "Thông tin cá nhân";
            // 
            // grbChucVu
            // 
            this.grbChucVu.AppearanceCaption.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.grbChucVu.AppearanceCaption.Options.UseFont = true;
            this.grbChucVu.Controls.Add(this.leChucVu);
            this.grbChucVu.Location = new System.Drawing.Point(18, 158);
            this.grbChucVu.Name = "grbChucVu";
            this.grbChucVu.Size = new System.Drawing.Size(396, 61);
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
            this.leChucVu.Size = new System.Drawing.Size(392, 32);
            this.leChucVu.TabIndex = 13;
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoSize = true;
            this.stackPanel1.Controls.Add(this.txtUsername);
            this.stackPanel1.Controls.Add(this.txtPassword);
            this.stackPanel1.Controls.Add(this.grbChucVu);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(2, 27);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(433, 242);
            this.stackPanel1.TabIndex = 15;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(18, 16);
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
            this.txtPassword.Location = new System.Drawing.Point(18, 89);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stackPanel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 271);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(437, 78);
            this.panelControl1.TabIndex = 1;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnLamLai.Appearance.Options.UseFont = true;
            this.btnLamLai.Location = new System.Drawing.Point(154, 13);
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
            this.btnDangKy.Location = new System.Drawing.Point(289, 13);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(131, 46);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.btnDangKy);
            this.stackPanel2.Controls.Add(this.btnLamLai);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel2.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel2.Location = new System.Drawing.Point(2, 2);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(433, 74);
            this.stackPanel2.TabIndex = 2;
            this.stackPanel2.UseSkinIndents = true;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 349);
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
            ((System.ComponentModel.ISupportInitialize)(this.grbChucVu)).EndInit();
            this.grbChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbTTCN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamLai;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private DevExpress.XtraEditors.GroupControl grbChucVu;
        private DevExpress.XtraEditors.LookUpEdit leChucVu;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
    }
}