using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 图片附件工具
    /// </summary>
    public partial class ImageAttachmentTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 相关附件
        /// </summary>
        private List<Attachment> attachments;
        #endregion //Field

        #region Constructor
        public ImageAttachmentTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="id">附件ID</param>
        private void SetImage(string id)
        {
            var imageStream = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Download(id);
            var image = Image.FromStream(imageStream);

            this.picView.Image = image;
            this.picView.Properties.ZoomPercent = 50;
        }
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
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageAttachmentTool_Load(object sender, EventArgs e)
        {
            picView.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            picView.Properties.AllowScrollViaMouseDrag = true;
        }

        /// <summary>
        /// 图片选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbAttachments.SelectedIndex == -1 || this.lbAttachments.SelectedItem == null)
                return;

            var select = this.lbAttachments.SelectedItem as Attachment;

            SetImage(select.Id);
        }

        /// <summary>
        /// 缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomBar_EditValueChanged(object sender, EventArgs e)
        {
            picView.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            picView.Properties.ZoomPercent = zoomBar.Value;
        }
        #endregion //Event
    }
}
