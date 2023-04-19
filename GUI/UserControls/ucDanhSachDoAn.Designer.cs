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
            this.stkFunction = new DevExpress.Utils.Layout.StackPanel();
            this.cmbLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grbData = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.stkFunction)).BeginInit();
            this.stkFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbData)).BeginInit();
            this.SuspendLayout();
            // 
            // stkFunction
            // 
            this.stkFunction.Controls.Add(this.cmbLoaiDoAn);
            this.stkFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.stkFunction.Location = new System.Drawing.Point(0, 0);
            this.stkFunction.Name = "stkFunction";
            this.stkFunction.Size = new System.Drawing.Size(698, 68);
            this.stkFunction.TabIndex = 2;
            this.stkFunction.UseSkinIndents = true;
            // 
            // cmbLoaiDoAn
            // 
            this.cmbLoaiDoAn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoaiDoAn.Font = new System.Drawing.Font("UTM Avo", 14F);
            this.cmbLoaiDoAn.FormattingEnabled = true;
            this.cmbLoaiDoAn.Location = new System.Drawing.Point(13, 16);
            this.cmbLoaiDoAn.Name = "cmbLoaiDoAn";
            this.cmbLoaiDoAn.Size = new System.Drawing.Size(121, 34);
            this.cmbLoaiDoAn.TabIndex = 1;
            this.cmbLoaiDoAn.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiDoAn_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grbData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(698, 449);
            this.panelControl1.TabIndex = 3;
            // 
            // grbData
            // 
            this.grbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbData.Location = new System.Drawing.Point(2, 2);
            this.grbData.Name = "grbData";
            this.grbData.ShowCaption = false;
            this.grbData.Size = new System.Drawing.Size(694, 445);
            this.grbData.TabIndex = 0;
            // 
            // ucDanhSachDoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.stkFunction);
            this.Name = "ucDanhSachDoAn";
            this.Size = new System.Drawing.Size(698, 517);
            this.Load += new System.EventHandler(this.ucDanhSachDoAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stkFunction)).EndInit();
            this.stkFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stkFunction;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl grbData;
        private System.Windows.Forms.ComboBox cmbLoaiDoAn;
    }
}
