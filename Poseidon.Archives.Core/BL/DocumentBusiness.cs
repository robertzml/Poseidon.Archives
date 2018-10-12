using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.IDAL;
    using Poseidon.Core.Utility;

    /// <summary>
    /// 档案业务类
    /// </summary>
    public class DocumentBusiness : AbstractBusiness<Document>, IBaseBL<Document>
    {
        #region Constructor
        /// <summary>
        /// 档案业务类
        /// </summary>
        public DocumentBusiness()
        {
            this.baseDal = RepositoryFactory<IDocumentRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按目录查询档案
        /// </summary>
        /// <param name="directoryId">目录ID</param>
        /// <returns></returns>
        public IEnumerable<Document> FindByDirecotry(string directoryId)
        {
            return this.baseDal.FindListByField("directoryId", directoryId);
        }

        /// <summary>
        /// 添加档案
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Document entity, ILoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            entity.Type = (int)FileType.Normal;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑档案
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Document entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            return base.Update(entity);
        }
        #endregion //Method
    }
}
