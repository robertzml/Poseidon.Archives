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
        #endregion //Function
    }
}
