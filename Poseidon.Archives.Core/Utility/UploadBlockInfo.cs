using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.Utility
{
    /// <summary>
    /// 上传文件分块信息
    /// </summary>
    public class UploadBlockInfo
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
        /// 文件路径
        /// </summary>
        [Display(Name = "文件路径")]
        public string LocalPath { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        public int Sequence { get; set; }

        /// <summary>
        /// 本块MD5
        /// </summary>
        [Display(Name = "本块MD5")]
        public string Md5Hash { get; set; }

        /// <summary>
        /// 分块数量
        /// </summary>
        [Display(Name = "分块数量")]
        public int BlockCount { get; set; }

        /// <summary>
        /// 整体MD5
        /// </summary>
        [Display(Name = "整体MD5")]
        public string TotalMd5Hash { get; set; }
        #endregion //Property
    }
}
