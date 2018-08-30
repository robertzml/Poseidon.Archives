namespace Poseidon.Archives.Test
{
    partial class FrmUploadTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attachmentUploadTool1 = new Poseidon.Archives.Utility.AttachmentUploadTool();
            this.SuspendLayout();
            // 
            // attachmentUploadTool1
            // 
            this.attachmentUploadTool1.Location = new System.Drawing.Point(12, 12);
            this.attachmentUploadTool1.Name = "attachmentUploadTool1";
            this.attachmentUploadTool1.Size = new System.Drawing.Size(315, 355);
            this.attachmentUploadTool1.TabIndex = 0;
            // 
            // FrmUploadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 502);
            this.Controls.Add(this.attachmentUploadTool1);
            this.Name = "FrmUploadTest";
            this.Text = "FrmUploadTest";
            this.Load += new System.EventHandler(this.FrmUploadTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.AttachmentUploadTool attachmentUploadTool1;
    }
}