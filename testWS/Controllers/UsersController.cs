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
        // GET api/users
        public IEnumerable<User> Get()
        {
            return data.Users;
        }

        // GET api/users/5
        public User Get(int id)
        {
            return data.Users.FirstOrDefault(u => u.Id == id);
        }

        // POST api/users
        public void Post([FromBody]User user)
        {
            data.Users.Add(user);
            data.SaveChanges();
        }

        // PUT api/users/5
        public void Put(int id, [FromBody]User user)
        {
            var usr = data.Users.FirstOrDefault(u => u.Id == id);
            usr.PassHash = user.PassHash;
            usr.Role = user.Role;
            usr.Username = user.Username;
            data.SaveChanges();

        }

        // DELETE api/users/5
        public void Delete(int id)
        {
            var usr = data.Users.Remove(data.Users.FirstOrDefault(u => u.Id == id));
            data.SaveChanges();
        }
    }
}
