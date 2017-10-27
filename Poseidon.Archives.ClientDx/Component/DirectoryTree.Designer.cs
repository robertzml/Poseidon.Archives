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
            this.components = new System.ComponentModel.Container();
            this.treeDir = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFileName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDatasetCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colStatus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsDirectory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // treeDir
            // 
            this.treeDir.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName,
            this.colFileName,
            this.colPath,
            this.colMount,
            this.colType,
            this.colDatasetCode,
            this.colRemark,
            this.colStatus});
            this.treeDir.DataSource = this.bsDirectory;
            this.treeDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDir.KeyFieldName = "Path";
            this.treeDir.Location = new System.Drawing.Point(0, 0);
            this.treeDir.Name = "treeDir";
            this.treeDir.OptionsBehavior.Editable = false;
            this.treeDir.OptionsBehavior.PopulateServiceColumns = true;
            this.treeDir.ParentFieldName = "Mount";
            this.treeDir.Size = new System.Drawing.Size(339, 405);
            this.treeDir.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 68;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 35;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "文件夹名";
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 1;
            this.colFileName.Width = 36;
            // 
            // colPath
            // 
            this.colPath.Caption = "路径";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 2;
            this.colPath.Width = 35;
            // 
            // colMount
            // 
            this.colMount.Caption = "挂载点";
            this.colMount.FieldName = "Mount";
            this.colMount.Name = "colMount";
            this.colMount.Visible = true;
            this.colMount.VisibleIndex = 3;
            this.colMount.Width = 36;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 36;
            // 
            // colDatasetCode
            // 
            this.colDatasetCode.Caption = "数据集代码";
            this.colDatasetCode.FieldName = "DatasetCode";
            this.colDatasetCode.Name = "colDatasetCode";
            this.colDatasetCode.Visible = true;
            this.colDatasetCode.VisibleIndex = 4;
            this.colDatasetCode.Width = 36;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            this.colRemark.Width = 36;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            this.colStatus.Width = 36;
            // 
            // bsDirectory
            // 
            this.bsDirectory.DataSource = typeof(Poseidon.Archives.Core.DL.Directory);
            // 
            // DirectoryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeDir);
            this.Name = "DirectoryTree";
            this.Size = new System.Drawing.Size(339, 405);
            ((System.ComponentModel.ISupportInitialize)(this.treeDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDirectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeDir;
        private System.Windows.Forms.BindingSource bsDirectory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPath;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDatasetCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colStatus;
    }
}
