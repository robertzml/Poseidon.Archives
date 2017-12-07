using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.Utility
{
    /// <summary>
    /// 上传文件信息
    /// </summary>
    public class UploadFileInfo
    {
        #region Property
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }

        /// <summary>
        /// MD5散列
        /// </summary>
        [Display(Name = "MD5散列")]
        public string MD5Hash { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [Display(Name = "文件路径")]
        public string LocalPath { get; set; }
        #endregion //Property
    }
}
