using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Archives.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Archives.Core.DL;
    using Poseidon.Archives.Core.IDAL;

    /// <summary>
    /// 附件对象访问类
    /// </summary>
    internal class AttachmentRepository : AbstractDALMongo<Attachment>, IAttachmentRepository
    {
        #region Constructor
        /// <summary>
        /// 附件对象访问类
        /// </summary>
        public AttachmentRepository()
        {
            base.Init("core_attachment");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Attachment DocToEntity(BsonDocument doc)
        {
            Attachment entity = new Attachment();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.FileName = doc["fileName"].ToString();
            entity.OriginName = doc["originName"].ToString();
            entity.Extension = doc["extension"].ToString();
            entity.ContentType = doc["contentType"].ToString();
            entity.Folder = doc["folder"].ToString();
            entity.Size = doc["size"].ToInt64();
            entity.UploadTime = doc["uploadTime"].ToLocalTime();
            entity.MD5Hash = doc["md5hash"].ToString();
            entity.Remark = doc["remark"].ToString();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Attachment entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "fileName", entity.FileName },
                { "originName", entity.OriginName },
                { "extension", entity.Extension },
                { "contentType", entity.ContentType },
                { "folder", entity.Folder },
                { "size", entity.Size },
                { "uploadTime", entity.UploadTime },
                { "md5hash", entity.MD5Hash },
                { "remark", entity.Remark }
            };

            return doc;
        }
        #endregion //Funtion

        #region Method
        /// <summary>
        /// 获取文件夹列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetFolders()
        {
            FilterDefinition<BsonDocument> match = "{}";

            ProjectionDefinition<BsonDocument, BsonDocument> group = new BsonDocument
            {
                { "_id", "$folder" }
            };

            var result = base.Aggregate(match, group);

            List<string> folders = new List<string>();
            foreach(var item in result)
            {
                folders.Add(item["_id"].ToString());
            }

            return folders;
        }
        #endregion //Method
    }
}
