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
    public partial class FrmUploadTest : Form
    {
        public FrmUploadTest()
        {
            InitializeComponent();
        }

        private void FrmUploadTest_Load(object sender, EventArgs e)
        {
            this.attachmentUploadTool1.Init("Test");
        }
    }
}
