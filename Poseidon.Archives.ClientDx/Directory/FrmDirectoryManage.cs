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
    /// 目录管理窗体
    /// </summary>
    public partial class FrmDirectoryManage : BaseMdiForm
    {
        #region Constructor
        public FrmDirectoryManage()
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
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmDirectoryAdd));
        }
        
        /// <summary>
        /// 编辑目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.dirTree.GetCurrentSelectId();
            if (id == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmDirectoryEdit), new object[] { id });
            LoadDirectory();
        }
        #endregion //Event
    }
}
