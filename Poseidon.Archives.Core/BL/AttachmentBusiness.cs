using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.IDAL;

    /// <summary>
    /// 附件业务类
    /// </summary>
    public class AttachmentBusiness : AbstractBusiness<Attachment>, IBaseBL<Attachment>
    {
        #region Constructor
        /// <summary>
        /// 附件业务类
        /// </summary>
        public AttachmentBusiness()
        {
            this.baseDal = RepositoryFactory<IAttachmentRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取文件夹列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetFolders()
        {
            var dal = this.baseDal as IAttachmentRepository;
            return dal.GetFolders();
        }
        #endregion //Method
    }
}
