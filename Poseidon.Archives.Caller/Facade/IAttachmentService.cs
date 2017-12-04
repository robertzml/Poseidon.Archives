using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Caller.Facade
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件业务访问服务接口
    /// </summary>
    public interface IAttachmentService : IBaseService<Attachment>
    {
        /// <summary>
        /// 异步上传单个附件
        /// </summary>
        /// <param name="data">上传附件信息</param>
        /// <returns></returns>
        Task<Attachment> UploadAsync(UploadInfo data);

        /// <summary>
        /// 同步上传单个附件
        /// </summary>
        /// <param name="data">上传附件信息</param>
        /// <returns></returns>
        Attachment Upload(UploadInfo data);

        /// <summary>
        /// 同步下载附件
        /// </summary>
        /// <param name="id"></param>
        Stream Download(string id);
        
        /// <summary>
        /// 按文件夹获取附件
        /// </summary>
        /// <param name="folder">文件夹</param>
        /// <returns></returns>
        IEnumerable<Attachment> FindByFolder(string folder);

        /// <summary>
        /// 获取文件夹列表
        /// </summary>
        /// <returns></returns>
        List<string> GetFolders();
    }
}
