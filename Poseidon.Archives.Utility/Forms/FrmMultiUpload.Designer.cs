namespace Poseidon.Archives.Utility
{
    partial class FrmMultiUpload
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
            this.uploadTool1 = new Poseidon.Archives.Utility.UploadTool();
            this.SuspendLayout();
            // 
            // uploadTool1
            // 
            this.uploadTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadTool1.Location = new System.Drawing.Point(0, 0);
            this.uploadTool1.Name = "uploadTool1";
            this.uploadTool1.Size = new System.Drawing.Size(620, 355);
            this.uploadTool1.TabIndex = 0;
            // 
            // FrmMultiUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 355);
            this.Controls.Add(this.uploadTool1);
            this.Name = "FrmMultiUpload";
            this.Text = "FrmMultiUpload";
            this.ResumeLayout(false);

        }

        #endregion

        private UploadTool uploadTool1;
    }
}