namespace Poseidon.Archives.ClientDx
{
    partial class DirectoryTree
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
            this.treeDir = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.treeDir)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDir
            // 
            this.treeDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDir.Location = new System.Drawing.Point(0, 0);
            this.treeDir.Name = "treeDir";
            this.treeDir.Size = new System.Drawing.Size(291, 347);
            this.treeDir.TabIndex = 0;
            // 
            // DirectoryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeDir);
            this.Name = "DirectoryTree";
            this.Size = new System.Drawing.Size(291, 347);
            ((System.ComponentModel.ISupportInitialize)(this.treeDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeDir;
    }
}
