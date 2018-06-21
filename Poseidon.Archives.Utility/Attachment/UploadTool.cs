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

namespace Poseidon.Archives.Utility
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件上传控件
    /// </summary>
    public partial class UploadTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 待上传文件数据
        /// </summary>
        private List<UploadFileInfo> uploadFileList = new List<UploadFileInfo>();

        /// <summary>
        /// 已上传文件数据
        /// </summary>
        private List<Attachment> attachmentList = new List<Attachment>();
        #endregion //Field

        #region Constructor
        public UploadTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 上传附件
        /// </summary>
        private async void StartUpload()
        {
            int fileCount = this.uploadFileList.Count;

            this.prgBar.Properties.Step = this.prgBar.Properties.Maximum / fileCount;
            this.prgBar.Position = 0;

            foreach (var item in this.uploadFileList)
            {
                try
                {
                    this.prgBar.PerformStep();

                    if (item.Status == UploadStatus.Complete)
                        continue;

                    var task = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).UploadAsync(item);

                    var r = await task;

                    if (task.IsCompleted)
                    {
                        item.Status = UploadStatus.Complete;
                        item.Id = r.Id;
                        this.attachmentList.Add(r);

                        this.uploadFileGrid.UpdateBindingData();
                    }
                    else
                        item.Status = UploadStatus.Error;
                }
                catch (Exception e)
                {
                    MessageUtil.ShowWarning(e.Message);
                }
            }

            this.prgBar.Position = this.prgBar.Properties.Maximum;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadFileGrid_Load(object sender, EventArgs e)
        {
            this.uploadFileGrid.DataSource = this.uploadFileList;
        }

        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var name in dialog.FileNames)
                    {
                        UploadFileInfo info = new UploadFileInfo();
                        info.Name = Path.GetFileNameWithoutExtension(name);
                        info.LocalPath = name;
                        info.Size = new FileInfo(name).Length / 1024;
                        info.MD5Hash = Hasher.GetFileMD5Hash(info.LocalPath);
                        info.Remark = "";
                        info.Status = 0;

                        this.uploadFileList.Add(info);
                    }

                    this.uploadFileGrid.UpdateBindingData();
                }
            }
            catch (Exception pe)
            {
                MessageUtil.ShowError(pe.Message);
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var fileInfo = this.uploadFileGrid.GetCurrentSelect();
            if (fileInfo == null)
                return;

            if (fileInfo.Status == UploadStatus.Error || fileInfo.Status == UploadStatus.No)
            {
                this.uploadFileList.Remove(fileInfo);
                this.uploadFileGrid.UpdateBindingData();
            }
            else
            {
                CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Delete(fileInfo.Id);
                this.uploadFileList.Remove(fileInfo);

                var attach = this.attachmentList.Single(r => r.Id == fileInfo.Id);
                this.attachmentList.Remove(attach);
            }
        }

        /// <summary>
        /// 开始上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            StartUpload();
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 待上传文件数据
        /// </summary>
        public List<UploadFileInfo> UploadFileList
        {
            get
            {
                return uploadFileList;
            }
        }

        /// <summary>
        /// 已上传文件数据
        /// </summary>
        public List<Attachment> AttachmentList
        {
            get
            {
                return attachmentList;
            }
        }
        #endregion //Property
    }
}
