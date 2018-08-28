using System;
using System.Collections.Generic;
using System.IO;
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

        #region Function
        /// <summary>
        /// 检查目录是否存在
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        private bool CheckExist(Directory entity)
        {
            var find = this.baseDal.FindOneByField("path", entity.Path);
            if (find == null)
                return false;
            else
            {
                if (find.Id == entity.Id)
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// 检查目录名是否含有非法字符
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        private bool CheckInvalidChar(Directory entity)
        {
            if (entity.FileName.IndexOfAny(Path.GetInvalidPathChars()) > 0)            
                return false;

            if (entity.FileName.IndexOfAny(new char[] { '/', '\\', '?', '#', '!', '@', '&', '$' }) > 0)
                return false;

            return true;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public void Create(Directory entity, ILoginUser user)
        {
            if (CheckExist(entity))
            {
                throw new PoseidonException("目录已存在");
            }
            if (!CheckInvalidChar(entity))
            {
                throw new PoseidonException("文件夹名含有非法字符");
            }

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

            entity.Type = (int)FileType.Directory;
            entity.Size = 0;
            entity.Extension = "";
            entity.ContentType = "";
            entity.Status = 0;

            entity.Path = entity.Mount + entity.FileName + "/";

            base.Create(entity);

            return;
        }

        /// <summary>
        /// 编辑目录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Directory entity, ILoginUser user)
        {
            if (CheckExist(entity))
            {
                throw new PoseidonException("目录已存在");
            }
            if (!CheckInvalidChar(entity))
            {
                throw new PoseidonException("文件夹名含有非法字符");
            }

            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            entity.Path = entity.Mount + entity.FileName + "/";

            return base.Update(entity);
        }
        #endregion //Method
    }
}
