
namespace TechTalks.DataAccessLayer.Dap
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Linq;
    using TechTalks.DataAccessLayer.Base;
    using TechTalks.DomainObjects;

    public partial class PostsDap : BaseDap
    {
        public PostsDap()
        {
        }

        public PostsDap(IDbConnection connection)
        {
            Connection = connection;
        }

        public PostsDap(IDbTransaction transaction)
        {
            Transaction = transaction;
            Connection = transaction.Connection;
        }

        public PostsDap(BaseDap dapProvider)
        {
            Transaction = dapProvider.Transaction;
            Connection = dapProvider.Connection;
        }

        public List<Posts> GetTop(int count)
        {
            return Query<Posts>(string.Format("SELECT TOP {0} * FROM {1}", count, SqlTableName)).ToList();
        }

        public Posts GetByPOST_ID(Int32 POST_ID)
        {
            return Query<Posts>(SqlSelectCommand + " WHERE POST_ID=@POST_ID", new { POST_ID = POST_ID }).FirstOrDefault();
        }

        public void Insert(Posts model)
        {
            Execute(SqlInsertCommand, model);
        }

        public void Insert(IEnumerable<Posts> models)
        {
            Execute(SqlInsertCommand, models);
        }

        public void Delete(Int32 POST_ID)
        {
            Execute(SqlDeleteCommand, new { POST_ID = POST_ID });
        }

        public void Update(Posts model)
        {
            Execute(SqlUpdateCommand, model);
        }

        public void Update(IEnumerable<Posts> models)
        {
            Execute(SqlUpdateCommand, models);
        }

        public List<PostTags> GetPOST_TAGSByPOST_ID(Int32 POST_ID)
        {
            using (var dap = new PostTagsDap(this))
            {
                return dap.GetByPOST_ID(POST_ID);
            }
        }
        public List<Posts> GetByUSER_ID(Int32 USER_ID)
        {
            return Query<Posts>(SqlSelectCommand + " WHERE USER_ID=@USER_ID", new { USER_ID = USER_ID }).ToList();
        }

        public Users GetUSERSByUSER_ID(Int32 USER_ID)
        {
            using (var dap = new UsersDap(this))
            {
                return dap.GetByUSER_ID(USER_ID);
            }
        }
        public List<Ratings> GetRATINGSByPOST_ID(Int32 POST_ID)
        {
            using (var dap = new RatingsDap(this))
            {
                return dap.GetByPOST_ID(POST_ID);
            }
        }



        public const string SqlTableName = "POSTS";
        public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
        public const string SqlInsertCommand = "INSERT INTO " + SqlTableName + " (TITLE , CONTENT , USER_ID , CRTE_DT , CRTE_BY , UPD_DT , UPD_BY , DEL_FLG) VALUES (@TITLE , @CONTENT , @USER_ID , @CRTE_DT , @CRTE_BY , @UPD_DT , @UPD_BY , @DEL_FLG) ";
        public const string SqlUpdateCommand = "UPDATE " + SqlTableName + " SET TITLE=@TITLE , CONTENT=@CONTENT , USER_ID=@USER_ID , CRTE_DT=@CRTE_DT , CRTE_BY=@CRTE_BY , UPD_DT=@UPD_DT , UPD_BY=@UPD_BY , DEL_FLG=@DEL_FLG WHERE POST_ID=@POST_ID";
        public const string SqlDeleteCommand = "DELETE FROM " + SqlTableName + " WHERE POST_ID=@POST_ID";

    }
}
