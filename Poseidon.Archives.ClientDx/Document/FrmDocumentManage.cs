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
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 档案管理窗体
    /// </summary>
    public partial class FrmDocumentManage : BaseMdiForm
    {
        #region Constructor
        public FrmDocumentManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadDirectory();
            base.InitForm();
        }

        /// <summary>
        /// 载入目录
        /// </summary>
        private void LoadDirectory()
        {
            var data = BusinessFactory<DirectoryBusiness>.Instance.FindAll().ToList();

            this.dirTree.Init(data);
        }

        /// <summary>
        /// 载入档案
        /// </summary>
        /// <param name="directoryId">目录ID</param>
        private void LoadDocument(string directoryId)
        {
            var data = BusinessFactory<DocumentBusiness>.Instance.FindByDirecotry(directoryId);
            this.docGrid.DataSource = data.ToList();
        }

        /// <summary>
        /// 显示文档信息
        /// </summary>
        /// <param name="document">选择文档</param>
        private void DisplayDocumentInfo(Document document)
        {
            this.txtName.Text = document.Name;
            this.txtFileName.Text = document.FileName;
            this.txtPath.Text = document.Path;
            this.txtMount.Text = document.Mount;
            this.txtExtension.Text = document.Extension;
            this.txtSize.Text = document.Size.ToString();
        }

        /// <summary>
        /// 清空文档显示
        /// </summary>
        private void ClearDocumentInfo()
        {
            this.txtName.Text = "";
            this.txtFileName.Text = "";
            this.txtPath.Text = "";
            this.txtMount.Text = "";
            this.txtExtension.Text = "";
            this.txtSize.Text = "";
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            var dirId = this.dirTree.GetCurrentSelectId();
            if (dirId == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDocumentAdd), new object[] { dirId });
        }

        /// <summary>
        /// 目录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirTree_DirectorySelected(object sender, EventArgs e)
        {
            var id = this.dirTree.GetCurrentSelectId();
            if (string.IsNullOrEmpty(id))
                return;

            LoadDocument(id);
        }

        /// <summary>
        /// 文件选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void docGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var select = this.docGrid.GetCurrentSelect();
            if (select == null)
            {
                ClearDocumentInfo();
            }
            else
            {
                DisplayDocumentInfo(select);
            }
        }
        #endregion //Event
    }
}
