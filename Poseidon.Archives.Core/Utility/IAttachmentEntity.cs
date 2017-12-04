using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.Utility
{
    /// <summary>
    /// 附件实体
    /// </summary>
    public interface IAttachmentEntity
    {
        /// <summary>
        /// 附件ID
        /// </summary>
        [Display(Name = "附件ID")]
        List<string> AttachmentIds { get; set; }
    }
}
