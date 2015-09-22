
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

    public partial class TagsDap : BaseDap
    {
        public TagsDap()
        {
        }

        public TagsDap(IDbConnection connection)
        {
            Connection = connection;
        }

        public TagsDap(IDbTransaction transaction)
        {
            Transaction = transaction;
            Connection = transaction.Connection;
        }

        public TagsDap(BaseDap dapProvider)
        {
            Transaction = dapProvider.Transaction;
            Connection = dapProvider.Connection;
        }

        public List<Tags> GetTop(int count)
        {
            return Query<Tags>(string.Format("SELECT TOP {0} * FROM {1}", count, SqlTableName)).ToList();
        }

        public Tags GetByTAG_ID(Int32 TAG_ID)
        {
            return Query<Tags>(SqlSelectCommand + " WHERE TAG_ID=@TAG_ID", new { TAG_ID = TAG_ID }).FirstOrDefault();
        }

        public void Insert(Tags model)
        {
            Execute(SqlInsertCommand, model);
        }

        public void Insert(IEnumerable<Tags> models)
        {
            Execute(SqlInsertCommand, models);
        }

        public void Delete(Int32 TAG_ID)
        {
            Execute(SqlDeleteCommand, new { TAG_ID = TAG_ID });
        }

        public void Update(Tags model)
        {
            Execute(SqlUpdateCommand, model);
        }

        public void Update(IEnumerable<Tags> models)
        {
            Execute(SqlUpdateCommand, models);
        }

        public List<PostTags> GetPOST_TAGSByTAG_ID(Int32 TAG_ID)
        {
            using (var dap = new PostTagsDap(this))
            {
                return dap.GetByTAG_ID(TAG_ID);
            }
        }



        public const string SqlTableName = "TAGS";
        public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
        public const string SqlInsertCommand = "INSERT INTO " + SqlTableName + " (TEXT , CRTE_DT , CRTE_BY , UPD_DT , UPD_BY , DEL_FLG) VALUES (@TEXT , @CRTE_DT , @CRTE_BY , @UPD_DT , @UPD_BY , @DEL_FLG) ";
        public const string SqlUpdateCommand = "UPDATE " + SqlTableName + " SET TEXT=@TEXT , CRTE_DT=@CRTE_DT , CRTE_BY=@CRTE_BY , UPD_DT=@UPD_DT , UPD_BY=@UPD_BY , DEL_FLG=@DEL_FLG WHERE TAG_ID=@TAG_ID";
        public const string SqlDeleteCommand = "DELETE FROM " + SqlTableName + " WHERE TAG_ID=@TAG_ID";

    }

}
