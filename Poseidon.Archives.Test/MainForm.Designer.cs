namespace Poseidon.Archives.Test
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.目录管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDirectoryMan = new System.Windows.Forms.ToolStripMenuItem();
            this.档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDocumentMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMultiUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.目录管理ToolStripMenuItem,
            this.档案管理ToolStripMenuItem,
            this.menuUpload});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 目录管理ToolStripMenuItem
            // 
            this.目录管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDirectoryMan});
            this.目录管理ToolStripMenuItem.Name = "目录管理ToolStripMenuItem";
            this.目录管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.目录管理ToolStripMenuItem.Text = "目录管理";
            // 
            // menuDirectoryMan
            // 
            this.menuDirectoryMan.Name = "menuDirectoryMan";
            this.menuDirectoryMan.Size = new System.Drawing.Size(124, 22);
            this.menuDirectoryMan.Text = "目录管理";
            this.menuDirectoryMan.Click += new System.EventHandler(this.menuDirectoryMan_Click);
            // 
            // 档案管理ToolStripMenuItem
            // 
            this.档案管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDocumentMan});
            this.档案管理ToolStripMenuItem.Name = "档案管理ToolStripMenuItem";
            this.档案管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.档案管理ToolStripMenuItem.Text = "档案管理";
            // 
            // menuDocumentMan
            // 
            this.menuDocumentMan.Name = "menuDocumentMan";
            this.menuDocumentMan.Size = new System.Drawing.Size(124, 22);
            this.menuDocumentMan.Text = "档案管理";
            this.menuDocumentMan.Click += new System.EventHandler(this.menuDocumentMan_Click);
            // 
            // menuUpload
            // 
            this.menuUpload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMultiUpload});
            this.menuUpload.Name = "menuUpload";
            this.menuUpload.Size = new System.Drawing.Size(68, 21);
            this.menuUpload.Text = "上传测试";
            // 
            // menuMultiUpload
            // 
            this.menuMultiUpload.Name = "menuMultiUpload";
            this.menuMultiUpload.Size = new System.Drawing.Size(152, 22);
            this.menuMultiUpload.Text = "多文件上传";
            this.menuMultiUpload.Click += new System.EventHandler(this.menuMultiUpload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 489);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "测试";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 目录管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDirectoryMan;
        private System.Windows.Forms.ToolStripMenuItem 档案管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDocumentMan;
        private System.Windows.Forms.ToolStripMenuItem menuUpload;
        private System.Windows.Forms.ToolStripMenuItem menuMultiUpload;
    }
}

