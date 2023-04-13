namespace GUI.UserControls
{
    partial class ucDoiMatKhau
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
            this.txtMatKhauHienTai = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauHienTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(156, 30);
            this.txtMatKhauHienTai.Margin = new System.Windows.Forms.Padding(3, 20, 3, 30);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Properties.AdvancedModeOptions.Label = "Mật khẩu hiện tại";
            this.txtMatKhauHienTai.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtMatKhauHienTai.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtMatKhauHienTai.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtMatKhauHienTai.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauHienTai.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtMatKhauHienTai.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMatKhauHienTai.Properties.AutoHeight = false;
            this.txtMatKhauHienTai.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(245, 57);
            this.txtMatKhauHienTai.TabIndex = 0;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(156, 120);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Properties.AdvancedModeOptions.Label = "Mật khẩu mới";
            this.txtMatKhauMoi.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtMatKhauMoi.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtMatKhauMoi.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtMatKhauMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauMoi.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtMatKhauMoi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMatKhauMoi.Properties.AutoHeight = false;
            this.txtMatKhauMoi.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtMatKhauMoi.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(245, 57);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(156, 210);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Properties.AdvancedModeOptions.Label = "Xác nhận mật khẩu";
            this.txtXacNhan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtXacNhan.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseFont = true;
            this.txtXacNhan.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtXacNhan.Properties.Appearance.Options.UseFont = true;
            this.txtXacNhan.Properties.AppearanceFocused.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.txtXacNhan.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtXacNhan.Properties.AutoHeight = false;
            this.txtXacNhan.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtXacNhan.Properties.UseSystemPasswordChar = true;
            this.txtXacNhan.Size = new System.Drawing.Size(245, 57);
            this.txtXacNhan.TabIndex = 2;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.txtMatKhauHienTai);
            this.stackPanel1.Controls.Add(this.txtMatKhauMoi);
            this.stackPanel1.Controls.Add(this.txtXacNhan);
            this.stackPanel1.Controls.Add(this.btnDoiMatKhau);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(558, 421);
            this.stackPanel1.TabIndex = 3;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(188, 299);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(182, 55);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật Khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ucDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stackPanel1);
            this.Name = "ucDoiMatKhau";
            this.Size = new System.Drawing.Size(558, 421);
            this.Load += new System.EventHandler(this.ucDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauHienTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMatKhauHienTai;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txtXacNhan;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
    }
}
