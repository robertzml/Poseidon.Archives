using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.Utility
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 上传文件信息
    /// </summary>
    public class UploadFileInfo : BaseEntity
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

        /// <summary>
        /// 文件大小KB
        /// </summary>
        [Display(Name = "文件大小KB")]
        public long Size { get; set; }

        /// <summary>
        /// 上传状态
        /// </summary>
        [Display(Name = "上传状态")]
        public UploadStatus Status { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 上传状态
    /// </summary>
    public enum UploadStatus
    {
        /// <summary>
        /// 未上传
        /// </summary>
        [Display(Name = "未上传")]
        No = 0,

        /// <summary>
        /// 已上传
        /// </summary>
        [Display(Name = "已上传")]
        Complete = 1,

        /// <summary>
        /// 上传失败
        /// </summary>
        [Display(Name = "上传失败")]
        Error = 2
    }
}
