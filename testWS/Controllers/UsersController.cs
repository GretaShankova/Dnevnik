using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWS.Controllers
{
    public class UsersController : ApiController
    {
        AppDbContext data = AppDbContext.Create();
        // GET api/values
        public IEnumerable<User> Get()
        {
            return data.Users;
        }

        // GET api/values/5
        public User Get(int id)
        {
            return data.Users.FirstOrDefault(u => u.Id == id);
        }

        // POST api/values
        public void Post([FromBody]User user)
        {
            data.Users.Add(user);
            data.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]User user)
        {
            var usr = data.Users.FirstOrDefault(u => u.Id == id);
            usr.PassHash = user.PassHash;
            usr.Role = user.Role;
            usr.Username = user.Username;
            data.SaveChanges();

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var usr = data.Users.Remove(data.Users.FirstOrDefault(u => u.Id == id));
            data.SaveChanges();
        }
    }
}
