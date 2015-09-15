using Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace SwaggerWebAPI.Controllers
{

    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
   
    public class UsersController : ApiController
    {
        // GET api/values
       
        public IEnumerable<User> Get()
        {
            
            return GetUsers();
        }
       
        private IEnumerable<User> GetUsers()
        {
            List<User> list = new List<User>();
            list.Add(new User { UserID = 1, UserName = "user1", Email = "user1@galaxe.com", DOB = "1/10/1990", FirstName = "user1" });
            list.Add(new User { UserID = 2, UserName = "user2", Email = "user2@galaxe.com", DOB = "2/10/1990", FirstName = "user2" });
            list.Add(new User { UserID = 3, UserName = "user3", Email = "user3@galaxe.com", DOB = "3/10/1990", FirstName = "user3" });
            list.Add(new User { UserID = 4, UserName = "user4", Email = "user4@galaxe.com", DOB = "4/10/1990", FirstName = "user4" });
            list.Add(new User { UserID = 5, UserName = "user5", Email = "user5@galaxe.com", DOB = "5/10/1990", FirstName = "user5" });
            return list;
        }
        // GET api/values/5
        public User Get(int id)
        {
            return GetUsers().FirstOrDefault(uc => uc.UserID == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("GetPosts")]
        public IEnumerable<User> GetPosts(int id)
        {
            List<User> list = new List<User>();
            list.Add(new User { UserID = 5, UserName = "Deepali", Email = "user1@galaxe.com", DOB = "1/10/1990", FirstName = "Deepali" });
            
            return list;
        }
    }
}