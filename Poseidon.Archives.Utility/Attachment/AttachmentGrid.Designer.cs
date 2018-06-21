namespace Poseidon.Archives.Utility
{
    partial class AttachmentGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentGrid));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgcAttachment = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bsAttachment = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMD5Hash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repActionButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repoCardButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.attachmentCardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadTime2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMd5Hash2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentCardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcAttachment
            // 
            this.dgcAttachment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgcAttachment.DataSource = this.bsAttachment;
            this.dgcAttachment.Location = new System.Drawing.Point(2, 26);
            this.dgcAttachment.MainView = this.attachmentGridView;
            this.dgcAttachment.Name = "dgcAttachment";
            this.dgcAttachment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repActionButton,
            this.repoCardButton});
            this.dgcAttachment.Size = new System.Drawing.Size(691, 374);
            this.dgcAttachment.TabIndex = 0;
            this.dgcAttachment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.attachmentGridView,
            this.attachmentCardView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(124, 22);
            this.menuDelete.Text = "删除附件";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // bsAttachment
            // 
            this.bsAttachment.DataSource = typeof(Poseidon.Archives.Core.DL.Attachment);
            // 
            // attachmentGridView
            // 
            this.attachmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colFileName,
            this.colOriginName,
            this.colExtension,
            this.colContentType,
            this.colMBSize,
            this.colFolder,
            this.colSize,
            this.colUploadTime,
            this.colMD5Hash,
            this.colRemark,
            this.colAction});
            this.attachmentGridView.GridControl = this.dgcAttachment;
            this.attachmentGridView.Name = "attachmentGridView";
            this.attachmentGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentGridView.OptionsCustomization.AllowGroup = false;
            this.attachmentGridView.OptionsFind.AlwaysVisible = true;
            this.attachmentGridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.attachmentGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.attachmentGridView.OptionsView.EnableAppearanceOddRow = true;
            this.attachmentGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.attachmentGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 85;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            // 
            // colOriginName
            // 
            this.colOriginName.Caption = "原始文件名";
            this.colOriginName.FieldName = "OriginName";
            this.colOriginName.Name = "colOriginName";
            this.colOriginName.OptionsColumn.AllowEdit = false;
            this.colOriginName.Visible = true;
            this.colOriginName.VisibleIndex = 1;
            this.colOriginName.Width = 85;
            // 
            // colExtension
            // 
            this.colExtension.Caption = "扩展名";
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.OptionsColumn.AllowEdit = false;
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 2;
            this.colExtension.Width = 85;
            // 
            // colContentType
            // 
            this.colContentType.Caption = "文件类型";
            this.colContentType.FieldName = "ContentType";
            this.colContentType.Name = "colContentType";
            this.colContentType.OptionsColumn.AllowEdit = false;
            this.colContentType.Visible = true;
            this.colContentType.VisibleIndex = 3;
            this.colContentType.Width = 85;
            // 
            // colMBSize
            // 
            this.colMBSize.Caption = "文件大小(MB)";
            this.colMBSize.FieldName = "colMBSize";
            this.colMBSize.Name = "colMBSize";
            this.colMBSize.OptionsColumn.AllowEdit = false;
            this.colMBSize.UnboundExpression = "Round(ToDecimal([Size]) / 1024 / 1024, 2)";
            this.colMBSize.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colMBSize.Visible = true;
            this.colMBSize.VisibleIndex = 4;
            // 
            // colFolder
            // 
            this.colFolder.Caption = "路径";
            this.colFolder.FieldName = "Folder";
            this.colFolder.Name = "colFolder";
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.OptionsColumn.AllowEdit = false;
            this.colSize.Width = 85;
            // 
            // colUploadTime
            // 
            this.colUploadTime.Caption = "上传时间";
            this.colUploadTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colUploadTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUploadTime.FieldName = "UploadTime";
            this.colUploadTime.Name = "colUploadTime";
            this.colUploadTime.OptionsColumn.AllowEdit = false;
            this.colUploadTime.Visible = true;
            this.colUploadTime.VisibleIndex = 5;
            this.colUploadTime.Width = 99;
            // 
            // colMD5Hash
            // 
            this.colMD5Hash.Caption = "文件Hash";
            this.colMD5Hash.FieldName = "MD5Hash";
            this.colMD5Hash.Name = "colMD5Hash";
            this.colMD5Hash.OptionsColumn.AllowEdit = false;
            this.colMD5Hash.Visible = true;
            this.colMD5Hash.VisibleIndex = 6;
            this.colMD5Hash.Width = 77;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.OptionsFilter.AllowFilter = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            this.colRemark.Width = 80;
            // 
            // colAction
            // 
            this.colAction.Caption = "操作";
            this.colAction.ColumnEdit = this.repActionButton;
            this.colAction.Name = "colAction";
            this.colAction.OptionsFilter.AllowFilter = false;
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 8;
            // 
            // repActionButton
            // 
            this.repActionButton.AutoHeight = false;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            serializableAppearanceObject2.Options.UseTextOptions = true;
            serializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repActionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Preview", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "下载", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repActionButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "Download", null, true)});
            this.repActionButton.Name = "repActionButton";
            this.repActionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repActionButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repActionButton_ButtonClick);
            // 
            // repoCardButton
            // 
            this.repoCardButton.AutoHeight = false;
            this.repoCardButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repoCardButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "Preview", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repoCardButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "Download", null, true)});
            this.repoCardButton.Name = "repoCardButton";
            this.repoCardButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoCardButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoCardButton_ButtonClick);
            // 
            // attachmentCardView
            // 
            this.attachmentCardView.CardCaptionFormat = "附件";
            this.attachmentCardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colOriginName2,
            this.colExtension2,
            this.colContentType2,
            this.gridColumn1,
            this.colSize2,
            this.colUploadTime2,
            this.colMd5Hash2,
            this.colRemark2,
            this.gridColumn2});
            this.attachmentCardView.FocusedCardTopFieldIndex = 0;
            this.attachmentCardView.GridControl = this.dgcAttachment;
            this.attachmentCardView.Name = "attachmentCardView";
            this.attachmentCardView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentCardView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentCardView.OptionsView.ShowCardExpandButton = false;
            // 
            // colName2
            // 
            this.colName2.Caption = "名称";
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.OptionsColumn.AllowEdit = false;
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 0;
            // 
            // colOriginName2
            // 
            this.colOriginName2.Caption = "原始文件名";
            this.colOriginName2.FieldName = "OriginName";
            this.colOriginName2.Name = "colOriginName2";
            this.colOriginName2.OptionsColumn.AllowEdit = false;
            this.colOriginName2.Visible = true;
            this.colOriginName2.VisibleIndex = 2;
            // 
            // colExtension2
            // 
            this.colExtension2.Caption = "扩展名";
            this.colExtension2.FieldName = "Extension";
            this.colExtension2.Name = "colExtension2";
            this.colExtension2.OptionsColumn.AllowEdit = false;
            this.colExtension2.Visible = true;
            this.colExtension2.VisibleIndex = 1;
            // 
            // colContentType2
            // 
            this.colContentType2.Caption = "文件类型";
            this.colContentType2.FieldName = "ContentType";
            this.colContentType2.Name = "colContentType2";
            this.colContentType2.OptionsColumn.AllowEdit = false;
            this.colContentType2.Visible = true;
            this.colContentType2.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "文件大小(MB)";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "Round(ToDecimal([Size]) / 1024 / 1024, 2)";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // colSize2
            // 
            this.colSize2.Caption = "文件大小";
            this.colSize2.FieldName = "Size";
            this.colSize2.Name = "colSize2";
            this.colSize2.OptionsColumn.AllowEdit = false;
            // 
            // colUploadTime2
            // 
            this.colUploadTime2.Caption = "上传时间";
            this.colUploadTime2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colUploadTime2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUploadTime2.FieldName = "UploadTime";
            this.colUploadTime2.Name = "colUploadTime2";
            this.colUploadTime2.OptionsColumn.AllowEdit = false;
            this.colUploadTime2.Visible = true;
            this.colUploadTime2.VisibleIndex = 5;
            // 
            // colMd5Hash2
            // 
            this.colMd5Hash2.Caption = "文件Hash";
            this.colMd5Hash2.FieldName = "MD5Hash";
            this.colMd5Hash2.Name = "colMd5Hash2";
            this.colMd5Hash2.OptionsColumn.AllowEdit = false;
            this.colMd5Hash2.Visible = true;
            this.colMd5Hash2.VisibleIndex = 6;
            // 
            // colRemark2
            // 
            this.colRemark2.Caption = "备注";
            this.colRemark2.FieldName = "Remark";
            this.colRemark2.Name = "colRemark2";
            this.colRemark2.OptionsColumn.AllowEdit = false;
            this.colRemark2.OptionsFilter.AllowFilter = false;
            this.colRemark2.Visible = true;
            this.colRemark2.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "操作";
            this.gridColumn2.ColumnEdit = this.repoCardButton;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(699, 440);
            this.panelControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.rgType);
            this.layoutControl1.Controls.Add(this.dgcAttachment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(695, 436);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.dgcAttachment;
            this.searchControl1.Location = new System.Drawing.Point(29, 2);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.dgcAttachment;
            this.searchControl1.Size = new System.Drawing.Size(664, 20);
            this.searchControl1.StyleController = this.layoutControl1;
            this.searchControl1.TabIndex = 5;
            // 
            // rgType
            // 
            this.rgType.EditValue = "GridView";
            this.rgType.Location = new System.Drawing.Point(2, 404);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Columns = 2;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("GridView", "表格视图"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CardView", "卡牌视图")});
            this.rgType.Size = new System.Drawing.Size(691, 30);
            this.rgType.StyleController = this.layoutControl1;
            this.rgType.TabIndex = 4;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
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
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(695, 436);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgcAttachment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(695, 378);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rgType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 402);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(695, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(695, 24);
            this.layoutControlItem3.Text = "搜索";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(24, 14);
            // 
            // AttachmentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "AttachmentGrid";
            this.Size = new System.Drawing.Size(699, 440);
            this.Load += new System.EventHandler(this.AttachmentGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcAttachment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repActionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentCardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcAttachment;
        private DevExpress.XtraGrid.Views.Grid.GridView attachmentGridView;
        private System.Windows.Forms.BindingSource bsAttachment;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colContentType;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadTime;
        private DevExpress.XtraGrid.Columns.GridColumn colMD5Hash;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMBSize;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repActionButton;
        private DevExpress.XtraGrid.Views.Card.CardView attachmentCardView;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginName2;
        private DevExpress.XtraGrid.Columns.GridColumn colContentType2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSize2;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadTime2;
        private DevExpress.XtraGrid.Columns.GridColumn colMd5Hash2;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoCardButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colFolder;
    }
}
