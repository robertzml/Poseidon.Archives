using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.Test
{
    using Poseidon.Winform.Base;
    using Poseidon.Archives.ClientDx;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuDirectoryMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmDirectoryManage));
        }

        private void menuDocumentMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmDocumentManage));
        }

        private void menuMultiUpload_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmMultiUpload));
        }

        private void menuAttachmentMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmAttachmentManage));
        }
    }
}
