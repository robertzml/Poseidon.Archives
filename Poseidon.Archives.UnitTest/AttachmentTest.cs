using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poseidon.Archives.UnitTest
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Archives.Caller.Facade;
    using Poseidon.Archives.Core.BL;
    using Poseidon.Archives.Core.DL;

    /// <summary>
    /// 附件测试
    /// </summary>
    [TestClass]
    public class AttachmentTest
    {
        #region Constructor
        public AttachmentTest()
        {
            // 设置连接字符串
            Cache.Instance.Add("ConnectionString", "mongodb://localhost:27017");

            // 设置数据库类型
            Cache.Instance.Add("DALPrefix", "Mongo");
        }
        #endregion //Constructor

        #region Test
        /// <summary>
        /// 业务类测试
        /// </summary>
        [TestMethod]
        public void FindInBuz()
        {
            var data = BusinessFactory<AttachmentBusiness>.Instance.FindAll();

            Assert.IsTrue(data.Count() > 0);

            foreach(var item in data)
            {
                Console.WriteLine("id:{0}, name:{1}", item.Id, item.Name);
            }
        }

        /// <summary>
        /// Winform方式读取数据
        /// </summary>
        [TestMethod]
        public void FindInWin()
        {
            var data = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindAll();

            Assert.IsTrue(data.Count() > 0);

            foreach (var item in data)
            {
                Console.WriteLine("id:{0}, name:{1}", item.Id, item.Name);
            }
        }

        [TestMethod]
        public void TestFindByFolder()
        {
            string folder = "2017-07";

            var data = CallerFactory<IAttachmentService>.GetInstance(CallerType.Win).FindByFolder(folder);

            Assert.IsTrue(data.Count() > 0);
            foreach (var item in data)
            {
                Console.WriteLine("id:{0}, name:{1}", item.Id, item.Name);
            }
        }

        [TestMethod]
        public void TestGroupByFolder()
        {
            var data = BusinessFactory<AttachmentBusiness>.Instance.GetFolders();

            Assert.IsTrue(data.Count > 0);

            foreach(var item in data)
            {
                Console.WriteLine("name:{0}", item);
            }
        }
        #endregion //Test
    }
}
