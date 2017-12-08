namespace Poseidon.Archives.ClientDx
{
    partial class ImageAttachmentTool
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.zoomBar = new DevExpress.XtraEditors.TrackBarControl();
            this.lbAttachments = new DevExpress.XtraEditors.ListBoxControl();
            this.bsAttachment = new System.Windows.Forms.BindingSource(this.components);
            this.picView = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(601, 345);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.zoomBar);
            this.layoutControl1.Controls.Add(this.lbAttachments);
            this.layoutControl1.Controls.Add(this.picView);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(597, 341);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // zoomBar
            // 
            this.zoomBar.EditValue = 50;
            this.zoomBar.Location = new System.Drawing.Point(139, 284);
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.zoomBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.zoomBar.Properties.Maximum = 100;
            this.zoomBar.Properties.TickFrequency = 5;
            this.zoomBar.Size = new System.Drawing.Size(446, 45);
            this.zoomBar.StyleController = this.layoutControl1;
            this.zoomBar.TabIndex = 6;
            this.zoomBar.Value = 50;
            this.zoomBar.EditValueChanged += new System.EventHandler(this.zoomBar_EditValueChanged);
            // 
            // lbAttachments
            // 
            this.lbAttachments.DataSource = this.bsAttachment;
            this.lbAttachments.DisplayMember = "Name";
            this.lbAttachments.Location = new System.Drawing.Point(12, 12);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(123, 317);
            this.lbAttachments.StyleController = this.layoutControl1;
            this.lbAttachments.TabIndex = 5;
            this.lbAttachments.ValueMember = "Id";
            this.lbAttachments.SelectedIndexChanged += new System.EventHandler(this.lbAttachments_SelectedIndexChanged);
            // 
            // bsAttachment
            // 
            this.bsAttachment.DataSource = typeof(Poseidon.Archives.Core.DL.Attachment);
            // 
            // picView
            // 
            this.picView.Location = new System.Drawing.Point(139, 12);
            this.picView.Name = "picView";
            this.picView.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.picView.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.picView.Properties.ShowScrollBars = true;
            this.picView.Size = new System.Drawing.Size(446, 268);
            this.picView.StyleController = this.layoutControl1;
            this.picView.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(597, 341);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.picView;
            this.layoutControlItem1.Location = new System.Drawing.Point(127, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(450, 272);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lbAttachments;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(127, 321);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.zoomBar;
            this.layoutControlItem3.Location = new System.Drawing.Point(127, 272);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 49);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(49, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(450, 49);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ImageAttachmentTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ImageAttachmentTool";
            this.Size = new System.Drawing.Size(601, 345);
            this.Load += new System.EventHandler(this.ImageAttachmentTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ListBoxControl lbAttachments;
        private DevExpress.XtraEditors.PictureEdit picView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bsAttachment;
        private DevExpress.XtraEditors.TrackBarControl zoomBar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
