using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poseidon.Attachment.UnitTest
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 附件服务测试
    /// </summary>
    [TestClass]
    public class AttachmentServerTest
    {
        #region Constructor
        public AttachmentServerTest()
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
        public void TestFind()
        {
            var data = CallerFactory<IAttachmentService>.Instance.FindAll();

            Assert.IsTrue(data.Count() > 0);
        }

        [TestMethod]
        public void TestFindBydId()
        {
            var data = CallerFactory<IAttachmentService>.Instance.FindById("594cd5a2672e210cbc5eb874");

            Assert.IsNotNull(data);
            Console.WriteLine(data.Name);
        }

        [TestMethod]
        public void TestFindAsync()
        {
            var data = CallerFactory<IAttachmentService>.Instance.FindAllAsync();

            var attachment = data.Result;

            Assert.IsTrue(attachment.Count() > 0);

            foreach (var item in attachment)
            {
                Console.WriteLine(item.FileName);
            }
        }

        /// <summary>
        /// 测试上传
        /// </summary>
        [TestMethod]
        public void TestUpload1()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\文档.doc";

            UploadFileInfo info = new UploadFileInfo();
            info.Name = "兔斯基";
            info.Remark = "8dfs";
            info.LocalPath = filePath;

            var result = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).UploadAsync(info);

            var attachment = result.Result;

            Assert.AreEqual(info.Name, attachment.Name);
        }

        /// <summary>
        /// 测试上传
        /// </summary>
        [TestMethod]
        public void TestUpload2()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\文档.doc";

            UploadFileInfo info = new UploadFileInfo();
            info.Name = "兔斯基";
            info.Remark = "qwert";
            info.LocalPath = filePath;

            var result = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Upload(info);

            var attachment = result;

            Assert.AreEqual(info.Name, attachment.Name);
        }

        /// <summary>
        /// 下载测试
        /// </summary>
        [TestMethod]
        public void TestDownload()
        {
            string id = "59648851672e2239b85b00d3";
            var stream = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Download(id);
        }


        [TestMethod]
        public void TestUpload3()
        {
            string[] files = new string[] { "E:/Test/poseidon.http", "E:/Test/dashboard.ejs" };

            var message = new HttpRequestMessage();
            var content = new MultipartFormDataContent();

            foreach (var file in files)
            {
                var filestream = new FileStream(file, FileMode.Open);
                var fileName = System.IO.Path.GetFileName(file);
                content.Add(new StreamContent(filestream), "file", fileName);
            }

            message.Method = HttpMethod.Post;
            message.Content = content;
            message.RequestUri = new Uri("http://localhost:4341/api/attachment/upload");

            var client = new HttpClient();
            client.SendAsync(message).ContinueWith(task =>
            {
                Assert.IsTrue(task.Result.IsSuccessStatusCode);
                if (task.Result.IsSuccessStatusCode)
                {
                    //do something with response
                }
            });
        }

        [TestMethod]
        public void TestUpload4()
        {
            string filePath = "E:/Test/dashboard.ejs";

            UploadFileInfo info = new UploadFileInfo();
            info.Name = "兔斯基";
            info.Remark = "qwert";
            info.MD5Hash = Hasher.GetFileMD5Hash(filePath);
            info.LocalPath = filePath;

            var result = CallerFactory<IAttachmentService>.GetInstance(CallerType.WebApi).Upload(info);

            var attachment = result;

            Assert.AreEqual(info.Name, attachment.Name);
        }
        #endregion //Test
    }
}
