namespace Poseidon.Archives.ClientDx
{
    partial class FrmAttachmentManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.attachmentGrid = new Poseidon.Archives.Utility.AttachmentGrid();
            this.folderTree = new System.Windows.Forms.TreeView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.attachmentGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(692, 555);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "附件列表";
            // 
            // attachmentGrid
            // 
            this.attachmentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachmentGrid.Location = new System.Drawing.Point(2, 21);
            this.attachmentGrid.Name = "attachmentGrid";
            this.attachmentGrid.Size = new System.Drawing.Size(688, 532);
            this.attachmentGrid.TabIndex = 0;
            // 
            // folderTree
            // 
            this.folderTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTree.Location = new System.Drawing.Point(2, 21);
            this.folderTree.Name = "folderTree";
            this.folderTree.Size = new System.Drawing.Size(190, 532);
            this.folderTree.TabIndex = 0;
            this.folderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.folderTree_AfterSelect);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.folderTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(194, 555);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "目录";
            // 
            // FrmAttachmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAttachmentManage";
            this.Text = "附件管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Archives.Utility.AttachmentGrid attachmentGrid;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TreeView folderTree;
    }
}