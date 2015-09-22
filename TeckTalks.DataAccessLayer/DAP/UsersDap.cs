
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

    public partial class UsersDap : BaseDap
    {
        public UsersDap()
        {
        }

        public UsersDap(IDbConnection connection)
        {
            Connection = connection;
        }

        public UsersDap(IDbTransaction transaction)
        {
            Transaction = transaction;
            Connection = transaction.Connection;
        }

        public UsersDap(BaseDap dapProvider)
        {
            Transaction = dapProvider.Transaction;
            Connection = dapProvider.Connection;
        }

        public List<Users> GetTop(int count)
        {
            return Query<Users>(string.Format("SELECT TOP {0} * FROM {1}", count, SqlTableName)).ToList();
        }

        public Users GetByUSER_ID(Int32 USER_ID)
        {
            return Query<Users>(SqlSelectCommand + " WHERE USER_ID=@USER_ID", new { USER_ID = USER_ID }).FirstOrDefault();
        }

        public void Insert(Users model)
        {
            Execute(SqlInsertCommand, model);
        }

        public void Insert(IEnumerable<Users> models)
        {
            Execute(SqlInsertCommand, models);
        }

        public void Delete(Int32 USER_ID)
        {
            Execute(SqlDeleteCommand, new { USER_ID = USER_ID });
        }

        public void Update(Users model)
        {
            Execute(SqlUpdateCommand, model);
        }

        public void Update(IEnumerable<Users> models)
        {
            Execute(SqlUpdateCommand, models);
        }

        public List<Posts> GetPOSTSByUSER_ID(Int32 USER_ID)
        {
            using (var dap = new PostsDap(this))
            {
                return dap.GetByUSER_ID(USER_ID);
            }
        }
        public List<Ratings> GetRATINGSByUSER_ID(Int32 USER_ID)
        {
            using (var dap = new RatingsDap(this))
            {
                return dap.GetByUSER_ID(USER_ID);
            }
        }



        public const string SqlTableName = "USERS";
        public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
        public const string SqlInsertCommand = "INSERT INTO " + SqlTableName + " (LOGIN_NAME , DISPLAY_NAME , TITLE , FIRST_NAME , LAST_NAME , EMAIL , STATUS , LAST_SUCCESS_LOGIN , LAST_FAIL_LOGIN , TOTAL_FAIL_LOGIN , CRTE_DT , CRTE_BY , UPD_DT , UPD_BY , DEL_FLG) VALUES (@LOGIN_NAME , @DISPLAY_NAME , @TITLE , @FIRST_NAME , @LAST_NAME , @EMAIL , @STATUS , @LAST_SUCCESS_LOGIN , @LAST_FAIL_LOGIN , @TOTAL_FAIL_LOGIN , @CRTE_DT , @CRTE_BY , @UPD_DT , @UPD_BY , @DEL_FLG) ";
        public const string SqlUpdateCommand = "UPDATE " + SqlTableName + " SET LOGIN_NAME=@LOGIN_NAME , DISPLAY_NAME=@DISPLAY_NAME , TITLE=@TITLE , FIRST_NAME=@FIRST_NAME , LAST_NAME=@LAST_NAME , EMAIL=@EMAIL , STATUS=@STATUS , LAST_SUCCESS_LOGIN=@LAST_SUCCESS_LOGIN , LAST_FAIL_LOGIN=@LAST_FAIL_LOGIN , TOTAL_FAIL_LOGIN=@TOTAL_FAIL_LOGIN , CRTE_DT=@CRTE_DT , CRTE_BY=@CRTE_BY , UPD_DT=@UPD_DT , UPD_BY=@UPD_BY , DEL_FLG=@DEL_FLG WHERE USER_ID=@USER_ID";
        public const string SqlDeleteCommand = "DELETE FROM " + SqlTableName + " WHERE USER_ID=@USER_ID";

    }
}
