using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件上传控件
    /// </summary>
    public partial class UploadTool : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        private List<UploadFileInfo> uploadFileList = new List<UploadFileInfo>();
        #endregion //Field

        #region Constructor
        public UploadTool()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //this.txtFile.Text = dialog.FileName;
                //this.txtName.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
            }
        }
        #endregion //Event
    }
}
