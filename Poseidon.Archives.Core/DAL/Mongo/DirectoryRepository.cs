﻿using System;
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
    /// 目录数据访问类
    /// </summary>
    internal class DirectoryRepository : AbstractDALMongo<Directory>, IDirectoryRepository
    {
        #region Constructor
        /// <summary>
        /// 目录数据访问类
        /// </summary>
        public DirectoryRepository()
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
        protected override Directory DocToEntity(BsonDocument doc)
        {
            Directory entity = new Directory();
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
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Directory entity)
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
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
