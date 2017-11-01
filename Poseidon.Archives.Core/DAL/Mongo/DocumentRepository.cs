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
    /// 档案数据访问类
    /// </summary>
    internal class DocumentRepository : AbstractDALMongo<Document>, IDocumentRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.Document;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 档案数据访问类
        /// </summary>
        public DocumentRepository()
        {
            base.Init("core_file");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Document DocToEntity(BsonDocument doc)
        {
            Document entity = new Document();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.FileName = doc["fileName"].ToString();
            entity.Extension = doc["extension"].ToString();
            entity.ContentType = doc["contentType"].ToString();
            entity.Size = doc["size"].ToInt32();
            entity.Mount = doc["mount"].ToString();
            entity.Type = doc["type"].ToInt32();
            entity.DatasetCode = doc["datasetCode"].ToString();
            entity.DirectoryId = doc["directoryId"].ToString();
            entity.Path = doc["path"].ToString();
            entity.Version = doc["version"].ToString();
            entity.PreviousId = doc["previousId"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            var updateBy = doc["updateBy"].ToBsonDocument();
            entity.UpdateBy = new UpdateStamp
            {
                UserId = updateBy["userId"].ToString(),
                Name = updateBy["name"].ToString(),
                Time = updateBy["time"].ToLocalTime()
            };

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Document entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "modelType", entity.ModelType },
                { "fileName", entity.FileName },
                { "extension", entity.Extension },
                { "contentType", entity.ContentType },
                { "size", entity.Size },
                { "mount", entity.Mount },
                { "type", entity.Type },
                { "datasetCode", entity.DatasetCode },
                { "directoryId", entity.DirectoryId },
                { "path", entity.Path },
                { "version", entity.Version },
                { "previousId", entity.PreviousId },
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "updateBy", new BsonDocument {
                    { "userId", entity.UpdateBy.UserId },
                    { "name", entity.UpdateBy.Name },
                    { "time", entity.UpdateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加档案
        /// </summary>
        /// <param name="entity">档案对象</param>
        /// <returns></returns>
        public override Document Create(Document entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
