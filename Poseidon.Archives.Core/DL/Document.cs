﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.DL
{
    using Poseidon.Core.DL;

    /// <summary>
    /// 档案类
    /// </summary>
    public class Document : File
    {
        #region Property
        /// <summary>
        /// 目录ID
        /// </summary>
        [Display(Name = "目录ID")]
        public string DirectoryId { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name = "路径")]
        public string Path { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name = "版本号")]
        public string Version { get; set; }

        /// <summary>
        /// 前版本
        /// </summary>
        [Display(Name = "前版本")]
        public string PreviousId { get; set; }

        /// <summary>
        /// 附件ID
        /// </summary>
        [Display(Name = "附件ID")]
        public string AttachmentId { get; set; }

        /// <summary>
        /// MD5哈希
        /// </summary>
        [Display(Name = "MD5哈希")]
        public string Md5Hash { get; set; }
        #endregion //Property
    }
}
