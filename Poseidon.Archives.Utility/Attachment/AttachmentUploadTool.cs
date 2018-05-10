using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.Utility
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 附件管理工具
    /// </summary>
    public partial class AttachmentUploadTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 相关附件
        /// </summary>
        private List<Attachment> attachments;
        #endregion //Field

        #region Constructor
        public AttachmentUploadTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ids"></param>
        public void Init(List<string> ids)
        {
            if (ids != null && ids.Count > 0)
                this.attachments = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindListInIds(ids).ToList();
            else
                this.attachments = new List<Attachment>();
            this.bsAttachment.DataSource = attachments;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.attachments = new List<Attachment>();
            this.bsAttachment.DataSource = attachments;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentTool_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 新增附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUpload upload = new FrmUpload();
            if (upload.ShowDialog() == DialogResult.OK)
            {
                this.attachments.Add(upload.Attachment);

                this.lbAttachments.Update();
            }
        }

        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lbAttachments.SelectedIndex == -1 || this.lbAttachments.SelectedItem == null)
                return;

            var attach = this.lbAttachments.SelectedItem as Attachment;
            if (MessageUtil.ConfirmYesNo("是否删除选定附件:" + attach.Name) == DialogResult.Yes)
            {
                bool result = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Delete(attach.Id);

                if (result)
                {
                    this.attachments.Remove(attach);
                }
                else
                {
                    MessageUtil.ShowWarning("删除附件失败");
                }
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
        #endregion //Property
    }
}
