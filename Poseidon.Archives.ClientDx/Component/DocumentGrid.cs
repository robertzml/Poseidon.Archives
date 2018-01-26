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
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 档案表格控件
    /// </summary>
    public partial class DocumentGrid : WinEntityGrid<Document>
    {
        #region Field
        /// <summary>
        /// 模式 1:查看模式  2:上传模式
        /// </summary>
        private int mode = 1;
        #endregion //Field

        #region Constructor
        public DocumentGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentGrid_Load(object sender, EventArgs e)
        {
            switch(this.mode)
            {
                case 1:
                    this.colVersion.Visible = true;                    
                    break;
                case 2:
                    this.colVersion.Visible = false;
                    break;
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 模式
        /// </summary>
        [Description("模式 1:查看模式  2:上传模式"), Category("界面"), Browsable(true)]
        public int Mode
        {
            get
            {
                return this.mode;
            }
            set
            {
                this.mode = value;
            }
        }
        #endregion //Property

    }
}
