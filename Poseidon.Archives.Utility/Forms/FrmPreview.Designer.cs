namespace Poseidon.Archives.Utility
{
    partial class FrmPreview
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
            this.picView = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.imgZoom = new DevExpress.XtraEditors.TrackBarControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZoom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 15);
            this.btnCancel.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(692, 18);
            this.btnConfirm.Text = "关闭";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Controls.Add(this.groupControl2);
            this.plFill.Size = new System.Drawing.Size(784, 502);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Controls.Add(this.btnDownload);
            this.plBottom.Controls.Add(this.btnPrint);
            this.plBottom.Location = new System.Drawing.Point(0, 502);
            this.plBottom.Size = new System.Drawing.Size(784, 60);
            this.plBottom.Controls.SetChildIndex(this.btnCancel, 0);
            this.plBottom.Controls.SetChildIndex(this.btnConfirm, 0);
            this.plBottom.Controls.SetChildIndex(this.btnPrint, 0);
            this.plBottom.Controls.SetChildIndex(this.btnDownload, 0);
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picView.Location = new System.Drawing.Point(2, 21);
            this.picView.Name = "picView";
            this.picView.Properties.AllowFocused = false;
            this.picView.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picView.Properties.AllowScrollViaMouseDrag = true;
            this.picView.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.picView.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.picView.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picView.Size = new System.Drawing.Size(780, 426);
            this.picView.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.picView);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(784, 449);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "附件";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.imgZoom);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 449);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(784, 53);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "信息";
            // 
            // imgZoom
            // 
            this.imgZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgZoom.EditValue = 50;
            this.imgZoom.Location = new System.Drawing.Point(2, 21);
            this.imgZoom.Name = "imgZoom";
            this.imgZoom.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.imgZoom.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.imgZoom.Properties.Maximum = 200;
            this.imgZoom.Properties.TickFrequency = 10;
            this.imgZoom.Size = new System.Drawing.Size(156, 30);
            this.imgZoom.TabIndex = 0;
            this.imgZoom.Value = 50;
            this.imgZoom.EditValueChanged += new System.EventHandler(this.imgZoom_EditValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(592, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(491, 18);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(80, 30);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "下载";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "FrmPreview";
            this.Text = "附件预览";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgZoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit picView;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TrackBarControl imgZoom;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
    }
}