using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件上传窗体
    /// </summary>
    public partial class FrmUpload : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 上传附件
        /// </summary>
        private Attachment attachment;
        #endregion //Field

        #region Constructor
        public FrmUpload()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtFile.Text.Trim()))
            {
                errorMessage = "上传文件不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtFile.Text = dialog.FileName;
                this.txtName.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var task = Task.Run(() =>
                {
                    UploadFileInfo info = new UploadFileInfo();
                    info.Name = this.txtName.Text;
                    info.LocalPath = this.txtFile.Text;
                    info.Remark = this.txtRemark.Text;

                    var result = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).UploadAsync(info);
                    return result;
                });

                this.attachment = await task;

                MessageUtil.ShowInfo(string.Format("上传文件:{0} 成功", attachment.Name));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageUtil.ShowError(ex.Message);
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 上传附件
        /// </summary>
        public Attachment Attachment
        {
            get
            {
                return attachment;
            }

            set
            {
                attachment = value;
            }
        }
        #endregion //Property
    }
}
