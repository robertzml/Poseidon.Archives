using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poseidon.Archives.UnitTest
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件WebApi测试
    /// </summary>
    [TestClass]
    public class AttachmentWebTest
    {
        #region Constructor
        public AttachmentWebTest()
        {
            // 设置连接字符串
            Cache.Instance.Add("ConnectionString", "mongodb://localhost:27017");

            // 设置数据库类型
            Cache.Instance.Add("DALPrefix", "Mongo");

            Cache.Instance.Add("CallerType", "webapi");

            Cache.Instance.Add("ApiHost", "http://localhost:4341/api/");
        }
        #endregion //Constructor

        #region Test
        [TestMethod]
        public void TestUploadSingleFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\tsj192.jpg";

            UploadFileInfo info = new UploadFileInfo();
            info.Name = "兔斯基";
            info.Remark = "8dfs";
            info.LocalPath = filePath;
            info.MD5Hash = Hasher.GetFileMD5Hash(filePath);

            var task = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).UploadAsync(info);
            //task.ContinueWith<Attachment>(r => Console)

            var attachment = task.Result;

            Assert.AreEqual(info.Name, attachment.Name);
        }
        #endregion //Test
    }
}
