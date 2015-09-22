
//namespace TechTalks.DataAccessLayer.Dap
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Data;
//    using System.Data.SqlClient;
//    using System.Configuration;
//    using System.Linq;
//    using TechTalks.DataAccessLayer.Base;
//    using TechTalks.DomainObjects;

//    public partial class PostTagsDap : BaseDap
//    {
//        public PostTagsDap()
//        {
//        }

//        public PostTagsDap(IDbConnection connection)
//        {
//            Connection = connection;
//        }

//        public PostTagsDap(IDbTransaction transaction)
//        {
//            Transaction = transaction;
//            Connection = transaction.Connection;
//        }

//        public PostTagsDap(BaseDap dapProvider)
//        {
//            Transaction = dapProvider.Transaction;
//            Connection = dapProvider.Connection;
//        }

//        public List<PostTags> GetTop(int count)
//        {
//            return Query<PostTags>(string.Format("SELECT TOP {0} * FROM {1}", count, SqlTableName)).ToList();
//        }

//        public PostTags GetByPOST_TAG_ID(Int32 POST_TAG_ID)
//        {
//            return Query<PostTags>(SqlSelectCommand + " WHERE POST_TAG_ID=@POST_TAG_ID", new { POST_TAG_ID = POST_TAG_ID }).FirstOrDefault();
//        }

//        public void Insert(PostTags model)
//        {
//            Execute(SqlInsertCommand, model);
//        }

//        public void Insert(IEnumerable<PostTags> models)
//        {
//            Execute(SqlInsertCommand, models);
//        }

//        public void Delete(Int32 POST_TAG_ID)
//        {
//            Execute(SqlDeleteCommand, new { POST_TAG_ID = POST_TAG_ID });
//        }

//        public void Update(PostTags model)
//        {
//            Execute(SqlUpdateCommand, model);
//        }

//        public void Update(IEnumerable<PostTags> models)
//        {
//            Execute(SqlUpdateCommand, models);
//        }

//        public List<PostTags> GetByPOST_ID(Int32 POST_ID)
//        {
//            return Query<PostTags>(SqlSelectCommand + " WHERE POST_ID=@POST_ID", new { POST_ID = POST_ID }).ToList();
//        }

//        public Posts GetPOSTSByPOST_ID(Int32 POST_ID)
//        {
//            using (var dap = new PostsDap(this))
//            {
//                return dap.GetByPOST_ID(POST_ID);
//            }
//        }
//        public List<PostTags> GetByTAG_ID(Int32 TAG_ID)
//        {
//            return Query<PostTags>(SqlSelectCommand + " WHERE TAG_ID=@TAG_ID", new { TAG_ID = TAG_ID }).ToList();
//        }

//        public Tags GetTAGSByTAG_ID(Int32 TAG_ID)
//        {
//            using (var dap = new TagsDap(this))
//            {
//                return dap.GetByTAG_ID(TAG_ID);
//            }
//        }



//        public const string SqlTableName = "POST_TAGS";
//        public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
//        public const string SqlInsertCommand = "INSERT INTO " + SqlTableName + " (POST_ID , TAG_ID , CRTE_DT , CRTE_BY , UPD_DT , UPD_BY , DEL_FLG) VALUES (@POST_ID , @TAG_ID , @CRTE_DT , @CRTE_BY , @UPD_DT , @UPD_BY , @DEL_FLG) ";
//        public const string SqlUpdateCommand = "UPDATE " + SqlTableName + " SET POST_ID=@POST_ID , TAG_ID=@TAG_ID , CRTE_DT=@CRTE_DT , CRTE_BY=@CRTE_BY , UPD_DT=@UPD_DT , UPD_BY=@UPD_BY , DEL_FLG=@DEL_FLG WHERE POST_TAG_ID=@POST_TAG_ID";
//        public const string SqlDeleteCommand = "DELETE FROM " + SqlTableName + " WHERE POST_TAG_ID=@POST_TAG_ID";

//    }

//}
