namespace Poseidon.Archives.ClientDx
{
    partial class FrmDocumentManage
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddDocument = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dirTree = new Poseidon.Archives.ClientDx.DirectoryTree();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.docGrid = new Poseidon.Archives.ClientDx.DocumentGrid();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 3);
            this.groupControl1.Controls.Add(this.btnAddDocument);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(883, 144);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(99, 59);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(75, 23);
            this.btnAddDocument.TabIndex = 0;
            this.btnAddDocument.Text = "添加文件";
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dirTree);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 153);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(194, 426);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "目录选择";
            // 
            // dirTree
            // 
            this.dirTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirTree.Location = new System.Drawing.Point(2, 21);
            this.dirTree.Name = "dirTree";
            this.dirTree.SimpleView = true;
            this.dirTree.Size = new System.Drawing.Size(190, 403);
            this.dirTree.TabIndex = 0;
            this.dirTree.DirectorySelected += new System.EventHandler(this.dirTree_DirectorySelected);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.docGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 153);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(338, 426);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "文件列表";
            // 
            // docGrid
            // 
            this.docGrid.AllowFilter = true;
            this.docGrid.AllowGroup = true;
            this.docGrid.AllowSort = true;
            this.docGrid.DataSource = null;
            this.docGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docGrid.Editable = false;
            this.docGrid.EnableMasterView = false;
            this.docGrid.EnableMultiSelect = false;
            this.docGrid.Location = new System.Drawing.Point(2, 21);
            this.docGrid.Name = "docGrid";
            this.docGrid.ShowAddMenu = false;
            this.docGrid.ShowFooter = false;
            this.docGrid.ShowLineNumber = true;
            this.docGrid.ShowMenu = false;
            this.docGrid.ShowNavigator = false;
            this.docGrid.Size = new System.Drawing.Size(334, 403);
            this.docGrid.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(547, 153);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(339, 426);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "文件信息";
            // 
            // FrmDocumentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDocumentManage";
            this.Text = "档案管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DirectoryTree dirTree;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnAddDocument;
        private DocumentGrid docGrid;
    }
}