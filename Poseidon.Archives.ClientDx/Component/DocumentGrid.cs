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
        public DocumentGrid()
        {
            InitializeComponent();
        }
    }
}
