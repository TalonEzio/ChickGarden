﻿namespace GUI
{
    partial class frmDangNhap
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.stpnlDangNhap = new DevExpress.Utils.Layout.StackPanel();
            this.hlDangKy = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpnlDangNhap)).BeginInit();
            this.stpnlDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(620, 174);
            this.panelControl1.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.btnDangNhap.Appearance.Options.UseBorderColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(230, 158);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(160, 52);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // stpnlDangNhap
            // 
            this.stpnlDangNhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.stpnlDangNhap.Appearance.Options.UseBackColor = true;
            this.stpnlDangNhap.Controls.Add(this.txtUsername);
            this.stpnlDangNhap.Controls.Add(this.txtPassword);
            this.stpnlDangNhap.Controls.Add(this.btnDangNhap);
            this.stpnlDangNhap.Controls.Add(this.hlDangKy);
            this.stpnlDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpnlDangNhap.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stpnlDangNhap.Location = new System.Drawing.Point(0, 174);
            this.stpnlDangNhap.Name = "stpnlDangNhap";
            this.stpnlDangNhap.Size = new System.Drawing.Size(620, 323);
            this.stpnlDangNhap.TabIndex = 5;
            this.stpnlDangNhap.UseSkinIndents = true;
            // 
            // hlDangKy
            // 
            this.hlDangKy.Appearance.Font = new System.Drawing.Font("UTM Avo", 16F);
            this.hlDangKy.Appearance.Options.UseFont = true;
            this.hlDangKy.Location = new System.Drawing.Point(267, 214);
            this.hlDangKy.Name = "hlDangKy";
            this.hlDangKy.Size = new System.Drawing.Size(86, 29);
            this.hlDangKy.TabIndex = 5;
            this.hlDangKy.Text = "Đăng Ký";
            this.hlDangKy.Click += new System.EventHandler(this.hlDangKy_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(159, 16);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AdvancedModeOptions.Label = "Tài khoản";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.AutoHeight = false;
            this.txtUsername.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtUsername.Size = new System.Drawing.Size(302, 61);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(159, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AdvancedModeOptions.Label = "Mật khẩu";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(302, 61);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 497);
            this.Controls.Add(this.stpnlDangNhap);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stpnlDangNhap)).EndInit();
            this.stpnlDangNhap.ResumeLayout(false);
            this.stpnlDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.Utils.Layout.StackPanel stpnlDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hlDangKy;
    }
}

