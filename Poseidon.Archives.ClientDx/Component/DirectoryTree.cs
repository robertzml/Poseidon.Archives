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
        #region Field
        /// <summary>
        /// 启用简单视图
        /// </summary>
        private bool simpleView = false;
        #endregion //Field

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

        /// <summary>
        /// 获取当前选中目录ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSelectId()
        {
            var node = this.treeDir.Selection[0];
            if (node == null)
                return null;
            else
                return node["Id"].ToString();
        }
        #endregion //Method
        
        #region Delegate
        /// <summary>
        /// 目录选择
        /// </summary>
        [Description("目录选择")]
        public event EventHandler DirectorySelected;
        #endregion //Delegate

        #region Event
        private void DirectoryTree_Load(object sender, EventArgs e)
        {
            this.colName.Visible = !this.simpleView;
            this.colPath.Visible = !this.simpleView;
            this.colMount.Visible = !this.simpleView;
            this.colDatasetCode.Visible = !this.simpleView;
            this.colRemark.Visible = !this.simpleView;
            this.colStatus.Visible = !this.simpleView;
        }

        /// <summary>
        /// 目录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDir_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            DirectorySelected?.Invoke(sender, e);
        }
        #endregion //Event


        #region Property
        /// <summary>
        /// 启用简单视图
        /// </summary>
        [Description("启用简单视图"), Browsable(true), Category("界面")]
        public bool SimpleView
        {
            get
            {
                return simpleView;
            }

            set
            {
                simpleView = value;
            }
        }
        #endregion //Property

    }
}
