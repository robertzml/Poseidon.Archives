using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Archives.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 添加文档窗体
    /// </summary>
    public partial class FrmDocumentAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 父级目录
        /// </summary>
        private Directory parentDirectory;
        #endregion //Field

        #region Constructor
        public FrmDocumentAdd(string directoryId)
        {
            InitializeComponent();
            InitData(directoryId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string directoryId)
        {
            this.parentDirectory = BusinessFactory<DirectoryBusiness>.Instance.FindById(directoryId);
        }

        protected override void InitForm()
        {
            this.txtMount.Text = this.parentDirectory.Path;
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (string.IsNullOrEmpty(this.txtFileName.Text.Trim()))
            {
                errorMessage = "文件名不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (string.IsNullOrEmpty(this.txtMount.Text.Trim()))
            {
                errorMessage = "挂载点不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Document entity)
        {
            entity.Name = this.txtName.Text;
            entity.FileName = this.txtFileName.Text;
            entity.DatasetCode = this.txtDatasetCode.Text;
            entity.Mount = this.txtMount.Text;
            entity.Remark = this.txtRemark.Text;

            entity.Size = 0;
            entity.Extension = "";
            entity.ContentType = "";

            entity.Version = "0.1";
            entity.PreviousId = "";
            entity.DirectoryId = this.parentDirectory.Id;

            entity.Path = entity.Mount + entity.FileName;
        }
        #endregion  //Function

        #region Event
        /// <summary>
        /// 保存文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Document entity = new Document();
                SetEntity(entity);

                BusinessFactory<DocumentBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
                Logger.Instance.Exception("新增档案失败", pe);
            }
        }
        #endregion //Event
    }
}
