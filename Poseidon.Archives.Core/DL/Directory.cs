using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.DL
{
    using Poseidon.Core.DL;

    /// <summary>
    /// 目录类
    /// </summary>
    public class Directory : File
    {
        #region Property
        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name = "路径")]
        public string Path { get; set; }
        #endregion //Property
    }
}
