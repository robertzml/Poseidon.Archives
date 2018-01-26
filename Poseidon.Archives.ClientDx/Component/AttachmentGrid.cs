using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 附件工具
    /// </summary>
    public partial class AttachmentGrid : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 是否显示上下文菜单
        /// </summary>
        private bool showContextMenu = false;

        /// <summary>
        /// 相关附件
        /// </summary>
        private List<Attachment> attachments;

        /// <summary>
        /// 当前视图
        /// </summary>
        private string currentView = "GridView";
        #endregion //Field

        #region Constructor
        public AttachmentGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 读取附件
        /// </summary>
        /// <param name="id">附件ID</param>
        /// <returns></returns>
        private Stream GetFile(string id)
        {
            var fileStream = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Download(id);
            return fileStream;
        }

        /// <summary>
        /// 预览文件
        /// </summary>
        /// <param name="attachment"></param>
        private void PreviewFile(Attachment attachment)
        {
            this.Cursor = Cursors.WaitCursor;
            var stream = GetFile(attachment.Id);
            this.Cursor = Cursors.Default;

            FrmPreview preview = new FrmPreview(attachment, stream);
            preview.ShowDialog();
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="attachment"></param>
        private void DownloadFile(Attachment attachment)
        {
            this.Cursor = Cursors.WaitCursor;
            var stream = GetFile(attachment.Id);
            this.Cursor = Cursors.Default;

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.RestoreDirectory = true;
            dialog.Filter = "All files(*.*)|*.*";
            dialog.FileName = attachment.OriginName;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = dialog.FileName.ToString();

                // 把 Stream 转换成 byte[]   
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                stream.Seek(0, SeekOrigin.Begin);

                // 把 byte[] 写入文件   
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bytes);
                bw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 表格动作
        /// </summary>
        /// <param name="action"></param>
        private void GridAction(string action)
        {
            Attachment attach = null;
            if (currentView == "GridView")
            {
                var selected = this.attachmentGridView.GetSelectedRows();
                if (selected.Length == 0)
                    return;

                var dsIndex = this.attachmentGridView.GetDataSourceRowIndex(selected[0]);
                attach = this.bsAttachment[dsIndex] as Attachment;
            }
            else if (currentView == "CardView")
            {
                var selected = this.attachmentCardView.GetSelectedRows();
                if (selected.Length == 0)
                    return;

                var dsIndex = this.attachmentCardView.GetDataSourceRowIndex(selected[0]);
                attach = this.bsAttachment[dsIndex] as Attachment;
            }

            try
            {
                if (action == "Preview")
                {
                    PreviewFile(attach);
                }
                else if (action == "Download")
                {
                    DownloadFile(attach);
                }
            }
            catch (PoseidonException pe)
            {
                this.Cursor = Cursors.Default;
                MessageUtil.ShowError(string.Format("错误类型:{0}, 网络状态:{1}", pe.ErrorCode.DisplayName(), pe.HttpStatusCode.ToString()));
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageUtil.ShowError(string.Format("远程访问错误，{0}", ex.InnerException.Message));
            }
        }

        /// <summary>
        /// 切换视图
        /// </summary>
        /// <param name="viewType"></param>
        private void ChangeView(string viewType)
        {
            switch (viewType)
            {
                case "GridView":
                    this.dgcAttachment.MainView = this.attachmentGridView;
                    break;
                case "CardView":
                    this.dgcAttachment.MainView = this.attachmentCardView;
                    break;
            }
            this.currentView = viewType;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ids">附件ID</param>
        public void Init(List<string> ids)
        {
            if (ids != null && ids.Count > 0)
                this.attachments = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindListInIds(ids).ToList();
            else
                this.attachments = new List<Attachment>();
            this.bsAttachment.DataSource = attachments;
        }

        /// <summary>
        /// 获取指定文件夹下附件
        /// </summary>
        /// <param name="folder">文件夹</param>
        public void Init(string folder)
        {
            this.attachments = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindByFolder(folder).ToList();
            this.bsAttachment.DataSource = attachments;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="data">附件数据</param>
        public void Init(List<Attachment> data)
        {
            this.attachments = data;
            this.bsAttachment.DataSource = attachments;
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            this.attachments = null;
        }

        /// <summary>
        /// 获取选中数据
        /// </summary>
        /// <returns></returns>
        public Attachment GetCurrentSelect()
        {
            int rowIndex = this.attachmentGridView.GetFocusedDataSourceRowIndex();
            if (rowIndex < 0 || rowIndex >= this.bsAttachment.Count)
                return null;
            else
                return this.bsAttachment[rowIndex] as Attachment;
        }

        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentGrid_Load(object sender, EventArgs e)
        {
            if (this.showContextMenu)
                this.dgcAttachment.ContextMenuStrip = this.contextMenuStrip1;
            else
                this.dgcAttachment.ContextMenuStrip = null;
        }

        /// <summary>
        /// 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridAction(e.Button.Tag.ToString());
        }

        /// <summary>
        /// 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repoCardButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridAction(e.Button.Tag.ToString());
        }

        /// <summary>
        /// 选择视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeView(this.rgType.EditValue.ToString());
        }

        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDelete_Click(object sender, EventArgs e)
        {
            var select = GetCurrentSelect();
            if (select == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除指定附件:" + select.Name) == DialogResult.Yes)
            {
                CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Delete(select.Id);
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 相关附件
        /// </summary>
        public List<Attachment> Attachments
        {
            get
            {
                return this.attachments;
            }
        }

        /// <summary>
        /// 相关附件ID
        /// </summary>
        public List<string> AttachmentIds
        {
            get
            {
                return this.attachments.Select(r => r.Id).ToList();
            }
        }

        /// <summary>
        /// 是否显示上下文菜单
        /// </summary>
        [Description("是否显示上下文菜单"), Category("界面"), Browsable(true)]
        public bool ShowContextMenu
        {
            get
            {
                return showContextMenu;
            }

            set
            {
                showContextMenu = value;
            }
        }
        #endregion //Property
    }
}
