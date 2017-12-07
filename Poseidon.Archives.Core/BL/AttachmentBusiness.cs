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
    using Poseidon.Common;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.IDAL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件业务类
    /// </summary>
    public class AttachmentBusiness : AbstractBusiness<Attachment>, IBaseBL<Attachment>
    {
        #region Field
        /// <summary>
        /// 分块文件大小 200M
        /// </summary>
        private readonly int maxBlockSize = 200000;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 附件业务类
        /// </summary>
        public AttachmentBusiness()
        {
            this.baseDal = RepositoryFactory<IAttachmentRepository>.Instance;
        }
        #endregion //Constructor

        #region Function
        #endregion //Function

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

        /// <summary>
        /// 读取附件
        /// </summary>
        /// <param name="root">根目录</param>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public FileStream ReadFile(string root, string id)
        {
            var attachment = this.baseDal.FindById(id);
            if (attachment == null)
                throw new PoseidonException(ErrorCode.ObjectNotFound);

            string path =Path.Combine(root, attachment.Folder, attachment.FileName);

            if (!File.Exists(path)) //文件已删除
                throw new PoseidonException(ErrorCode.ObjectDeleted);

            FileStream fs = new FileStream(path, FileMode.Open);
            return fs;            
        }
        #endregion //Method
    }
}
