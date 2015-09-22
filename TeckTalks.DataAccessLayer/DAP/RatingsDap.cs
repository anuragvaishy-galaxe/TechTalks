
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

    public partial class RatingsDap : BaseDap
    {
        public RatingsDap()
        {
        }

        public RatingsDap(IDbConnection connection)
        {
            Connection = connection;
        }

        public RatingsDap(IDbTransaction transaction)
        {
            Transaction = transaction;
            Connection = transaction.Connection;
        }

        public RatingsDap(BaseDap dapProvider)
        {
            Transaction = dapProvider.Transaction;
            Connection = dapProvider.Connection;
        }

        public List<Ratings> GetTop(int count)
        {
            return Query<Ratings>(string.Format("SELECT TOP {0} * FROM {1}", count, SqlTableName)).ToList();
        }

        public Ratings GetByRATING_ID(Int32 RATING_ID)
        {
            return Query<Ratings>(SqlSelectCommand + " WHERE RATING_ID=@RATING_ID", new { RATING_ID = RATING_ID }).FirstOrDefault();
        }

        public void Insert(Ratings model)
        {
            Execute(SqlInsertCommand, model);
        }

        public void Insert(IEnumerable<Ratings> models)
        {
            Execute(SqlInsertCommand, models);
        }

        public void Delete(Int32 RATING_ID)
        {
            Execute(SqlDeleteCommand, new { RATING_ID = RATING_ID });
        }

        public void Update(Ratings model)
        {
            Execute(SqlUpdateCommand, model);
        }

        public void Update(IEnumerable<Ratings> models)
        {
            Execute(SqlUpdateCommand, models);
        }

        public List<Ratings> GetByUSER_ID(Int32 USER_ID)
        {
            return Query<Ratings>(SqlSelectCommand + " WHERE USER_ID=@USER_ID", new { USER_ID = USER_ID }).ToList();
        }

        public Users GetUSERSByUSER_ID(Int32 USER_ID)
        {
            using (var dap = new UsersDap(this))
            {
                return dap.GetByUSER_ID(USER_ID);
            }
        }
        public List<Ratings> GetByPOST_ID(Int32 POST_ID)
        {
            return Query<Ratings>(SqlSelectCommand + " WHERE POST_ID=@POST_ID", new { POST_ID = POST_ID }).ToList();
        }

        public Posts GetPOSTSByPOST_ID(Int32 POST_ID)
        {
            using (var dap = new PostsDap(this))
            {
                return dap.GetByPOST_ID(POST_ID);
            }
        }

        public const string SqlTableName = "RATINGS";
        public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
        public const string SqlInsertCommand = "INSERT INTO " + SqlTableName + " (STAR_RATING , USER_ID , POST_ID , CRTE_DT , CRTE_BY , UPD_DT , UPD_BY , DEL_FLG) VALUES (@STAR_RATING , @USER_ID , @POST_ID , @CRTE_DT , @CRTE_BY , @UPD_DT , @UPD_BY , @DEL_FLG) ";
        public const string SqlUpdateCommand = "UPDATE " + SqlTableName + " SET STAR_RATING=@STAR_RATING , USER_ID=@USER_ID , POST_ID=@POST_ID , CRTE_DT=@CRTE_DT , CRTE_BY=@CRTE_BY , UPD_DT=@UPD_DT , UPD_BY=@UPD_BY , DEL_FLG=@DEL_FLG WHERE RATING_ID=@RATING_ID";
        public const string SqlDeleteCommand = "DELETE FROM " + SqlTableName + " WHERE RATING_ID=@RATING_ID";

    }
}
