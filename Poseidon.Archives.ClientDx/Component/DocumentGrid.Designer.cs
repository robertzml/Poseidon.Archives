namespace Poseidon.Archives.ClientDx
{
    partial class DocumentGrid
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
            this.colDirectoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreviousId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Archives.Core.DL.Document);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDirectoryId,
            this.colPath,
            this.colVersion,
            this.colPreviousId,
            this.colModelType,
            this.colFileName,
            this.colExtension,
            this.colContentType,
            this.colSize,
            this.colMount,
            this.colType,
            this.colDatasetCode,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colDirectoryId
            // 
            this.colDirectoryId.FieldName = "DirectoryId";
            this.colDirectoryId.Name = "colDirectoryId";
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 1;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 2;
            // 
            // colPreviousId
            // 
            this.colPreviousId.FieldName = "PreviousId";
            this.colPreviousId.Name = "colPreviousId";
            this.colPreviousId.Visible = true;
            this.colPreviousId.VisibleIndex = 3;
            // 
            // colModelType
            // 
            this.colModelType.FieldName = "ModelType";
            this.colModelType.Name = "colModelType";
            this.colModelType.Visible = true;
            this.colModelType.VisibleIndex = 4;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 5;
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 6;
            // 
            // colContentType
            // 
            this.colContentType.FieldName = "ContentType";
            this.colContentType.Name = "colContentType";
            this.colContentType.Visible = true;
            this.colContentType.VisibleIndex = 7;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 8;
            // 
            // colMount
            // 
            this.colMount.FieldName = "Mount";
            this.colMount.Name = "colMount";
            this.colMount.Visible = true;
            this.colMount.VisibleIndex = 9;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 10;
            // 
            // colDatasetCode
            // 
            this.colDatasetCode.FieldName = "DatasetCode";
            this.colDatasetCode.Name = "colDatasetCode";
            this.colDatasetCode.Visible = true;
            this.colDatasetCode.VisibleIndex = 11;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 12;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // DocumentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocumentGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDirectoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colPreviousId;
        private DevExpress.XtraGrid.Columns.GridColumn colModelType;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colContentType;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colMount;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasetCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
