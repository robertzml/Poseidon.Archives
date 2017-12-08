using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件预览窗体
    /// </summary>
    public partial class FrmPreview : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 附件
        /// </summary>
        private Attachment attchment;

        /// <summary>
        /// 数据流
        /// </summary>
        private Stream stream;


        PrintDocument printDocument = new PrintDocument();
        #endregion //Field

        #region Constructor
        public FrmPreview(Attachment attchment, Stream stream)
        {
            InitializeComponent();

            this.attchment = attchment;
            this.stream = stream;
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            SetImage(this.stream);

            this.picView.MouseWheel += PicView_MouseWheel;
            base.InitForm();
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="stream">数据流</param>
        private void SetImage(Stream stream)
        {
            try
            {
                var image = Image.FromStream(stream);

                this.picView.Image = image;
                this.picView.Properties.ZoomPercent = 50;
            }
            catch (Exception)
            {
                MessageUtil.ShowWarning("不是图片数据");
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="attachment">附件</param>
        private void DownloadFile(Attachment attachment)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.RestoreDirectory = true;
            dialog.Filter = "All files(*.*)|*.*";
            dialog.FileName = attachment.OriginName;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = dialog.FileName.ToString();

                // 把 Stream 转换成 byte[]   
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                stream.Seek(0, SeekOrigin.Begin);

                // 把 byte[] 写入文件   
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(bytes);
                bw.Close();
                fs.Close();
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 图片缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgZoom_EditValueChanged(object sender, EventArgs e)
        {
            picView.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
            picView.Properties.ZoomPercent = imgZoom.Value;
        }

        /// <summary>
        /// 图片缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                this.imgZoom.Value += 5;
            else if (e.Delta < 0)
                this.imgZoom.Value -= 5;
        }

        /// <summary>
        /// 设置打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (picView.Image != null)
            {
                e.Graphics.DrawImage(picView.Image, e.Graphics.VisibleClipBounds);
                e.HasMorePages = false;
            }
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printDocument.DefaultPageSettings.PaperSize = new PaperSize();
            this.printDocument.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;

            //注册PrintPage事件，打印每一页时会触发该事件
            printDocument.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                //页面设置对话框
                PageSetupDialog psd = new PageSetupDialog();
                psd.Document = printDocument;
                if (psd.ShowDialog() == DialogResult.OK)
                {
                    //打印预览
                    PrintPreviewDialog ppd = new PrintPreviewDialog();
                    ppd.Document = printDocument;
                    if (ppd.ShowDialog() == DialogResult.OK)
                        printDocument.Print(); //打印
                }
            }
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadFile(this.attchment);
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Event
    }
}
