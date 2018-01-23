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
        private async void StartUpload()
        {
            List<Task<Attachment>> tasks = new List<Task<Attachment>>();

            foreach (var item in this.uploadFileList)
            {
                var task = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).UploadAsync(item);
                                
                var r = await task;

                if (task.IsCompleted)
                {
                    item.Status = UploadStatus.Complete;
                    this.attachmentList.Add(r);

                    this.uploadFileGrid.UpdateBindingData();
                }
                else
                    item.Status = UploadStatus.Error;
            }
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
                        info.MD5Hash = Hasher.GetFileMD5Hash(info.LocalPath);
                        info.Remark = "";
                        info.Status = 0;

                        this.uploadFileList.Add(info);
                    }

                    this.uploadFileGrid.UpdateBindingData();
                }
            }
            catch(Exception pe)
            {
                MessageUtil.ShowError(pe.Message);
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
    }
}
