using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;
    using DevExpress.XtraTreeList.Nodes;

    /// <summary>
    /// 附件管理窗体
    /// </summary>
    public partial class FrmAttachmentManage : BaseMdiForm
    {
        #region Constructor
        public FrmAttachmentManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化文件夹树
        /// </summary>
        private void InitFolders()
        {
            var folders = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).GetFolders().OrderByDescending(r => r);

            var topNode = this.folderTree.Nodes.Add("-1", "root");

            foreach (var item in folders)
            {
                topNode.Nodes.Add(item);
            }

            this.folderTree.ExpandAll();
        }

        protected override void InitForm()
        {
            InitFolders();

            if (this.currentUser.IsRoot)
                this.attachmentGrid.ShowContextMenu = true;
            else
                this.attachmentGrid.ShowContextMenu = false;

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void folderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.folderTree.SelectedNode == null)
                return;

            var folder = this.folderTree.SelectedNode.Text;

            if (folder == "root")
            {
                var data = CallerFactory<IAttachmentService>.Instance.FindAll().ToList();
                this.attachmentGrid.Init(data);
            }
            else
            {
                this.attachmentGrid.Init(folder);
            }
        }
        #endregion //Event
    }
}
