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
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 目录树控件
    /// </summary>
    public partial class DirectoryTree : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public DirectoryTree()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化文件夹树
        /// </summary>
        /// <param name="data"></param>
        public void Init(List<Directory> data)
        {
            this.bsDirectory.DataSource = data;
        }
        #endregion //Method
    }
}
