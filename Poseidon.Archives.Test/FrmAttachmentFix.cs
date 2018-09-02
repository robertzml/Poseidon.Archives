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
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;

    public partial class FrmAttachmentFix : Form
    {
        public FrmAttachmentFix()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = BusinessFactory<AttachmentBusiness>.Instance.FindAll();

            foreach(var item in data)
            {
                item.Folder = "Default/" + item.Folder;

                bool result = BusinessFactory<AttachmentBusiness>.Instance.Update(item);
                if (!result)
                    MessageBox.Show("error");
            }

            MessageBox.Show("ok");
        }
    }
}
