using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Caller.WinformCaller
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件业务访问服务类
    /// </summary>
    internal class AttachmentService : AbstractLocalService<Attachment>, IAttachmentService
    {
        #region Field
        /// <summary>
        /// 业务类对象
        /// </summary>
        private AttachmentBusiness bl = null;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 附件业务访问服务类
        /// </summary>
        public AttachmentService() : base(BusinessFactory<AttachmentBusiness>.Instance)
        {
            this.bl = this.baseBL as AttachmentBusiness;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 异步上传单个附件
        /// </summary>
        /// <param name="data">上传附件信息</param>
        /// <returns></returns>
        public async Task<Attachment> UploadAsync(UploadInfo data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 同步上传单个附件
        /// </summary>
        /// <param name="data">上传附件信息</param>
        /// <returns></returns>
        public Attachment Upload(UploadInfo data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 同步下载附件
        /// </summary>
        /// <param name="id"></param>
        public Stream Download(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 按文件夹获取附件
        /// </summary>
        /// <param name="folder">文件夹</param>
        /// <returns></returns>
        public IEnumerable<Attachment> FindByFolder(string folder)
        {
            return this.bl.FindListByField("folder", folder);
        }

        /// <summary>
        /// 获取文件夹列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetFolders()
        {
            return this.bl.GetFolders();
        }
        #endregion //Method
    }
}
