using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.Utility
{
    using Poseidon.Winform.Base;

    /// <summary>
    /// 多文件上传窗体
    /// </summary>
    public partial class FrmMultiUpload : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 模块名称
        /// </summary>
        private string module;
        #endregion //Field

        #region Constructor
        public FrmMultiUpload(string module)
        {
            this.module = module;

            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.uploadTool.Init(this.module);

            base.InitForm();
        }
        #endregion //Function
    }
}
