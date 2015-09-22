
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

    public partial interface IPostsDap : IBaseDap
    {
        List<Posts> GetTop(int count);

        Posts GetByPOST_ID(Int32 POST_ID);

        void Insert(Posts model);

        void Insert(IEnumerable<Posts> models);

        void Delete(Int32 POST_ID);

        void Update(Posts model);

        void Update(IEnumerable<Posts> models);

        List<PostTags> GetPOST_TAGSByPOST_ID(Int32 POST_ID);
        List<Posts> GetByUSER_ID(Int32 USER_ID);

        Users GetUSERSByUSER_ID(Int32 USER_ID);
        List<Ratings> GetRATINGSByPOST_ID(Int32 POST_ID);
      
    }
}
