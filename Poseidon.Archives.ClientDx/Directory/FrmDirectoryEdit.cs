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
    /// 编辑目录窗体
    /// </summary>
    public partial class FrmDirectoryEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联目录
        /// </summary>
        private Directory currentDirectory;
        #endregion //Field

        #region Constructor
        public FrmDirectoryEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentDirectory = BusinessFactory<DirectoryBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentDirectory.Name;
            this.txtFileName.Text = this.currentDirectory.FileName;
            this.txtMount.Text = this.currentDirectory.Mount;
            this.txtDatasetCode.Text = this.currentDirectory.DatasetCode;
            this.txtRemark.Text = this.currentDirectory.Remark;

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
                errorMessage = "文件夹名不能为空";
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
        private void SetEntity(Directory entity)
        {
            entity.Name = this.txtName.Text;
            entity.FileName = this.txtFileName.Text;
            entity.DatasetCode = this.txtDatasetCode.Text;
            entity.Mount = this.txtMount.Text;
            entity.Remark = this.txtRemark.Text;

            entity.Path = entity.Mount + entity.Name;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
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
                var entity = BusinessFactory<DirectoryBusiness>.Instance.FindById(this.currentDirectory.Id);
                SetEntity(entity);

                BusinessFactory<DirectoryBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
