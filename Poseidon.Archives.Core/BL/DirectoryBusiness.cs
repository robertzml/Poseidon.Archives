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
    /// 目录业务类
    /// </summary>
    public class DirectoryBusiness : AbstractBusiness<Directory>, IBaseBL<Directory>
    {
        #region Constructor
        /// <summary>
        /// 目录业务类
        /// </summary>
        public DirectoryBusiness()
        {
            this.baseDal = RepositoryFactory<IDirectoryRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Directory entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            entity.Type = (int)FileType.Directory;
            entity.Size = 0;
            entity.Extension = "";
            entity.ContentType = "";
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑目录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Directory entity, LoginUser user)
        {
            return base.Update(entity);
        }
        #endregion //Method
    }
}
