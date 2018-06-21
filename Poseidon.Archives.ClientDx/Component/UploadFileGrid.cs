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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 上传文件表格控件
    /// </summary>
    public partial class UploadFileGrid : WinEntityGrid<UploadFileInfo>
    {
        #region Constructor
        public UploadFileGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var list = this.bsEntity.DataSource as List<UploadFileInfo>;
            if (e.Column.FieldName == "Status")
            {
                e.DisplayText = ((UploadStatus)e.Value).DisplayName();
            }
        }
        #endregion //Event
    }
}
