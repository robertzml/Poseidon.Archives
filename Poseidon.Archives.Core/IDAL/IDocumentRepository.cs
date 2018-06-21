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
    /// 档案数据访问接口
    /// </summary>
    internal interface IDocumentRepository : IBaseDAL<Document>
    {
    }
}
