using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 附件对象访问接口
    /// </summary>
    internal interface IAttachmentRepository : IBaseDAL<Attachment>
    {
        /// <summary>
        /// 获取文件夹列表
        /// </summary>
        /// <returns></returns>
        List<string> GetFolders();
    }
}
