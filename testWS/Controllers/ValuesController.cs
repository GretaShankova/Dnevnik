using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWS.Controllers
{
    public class ValuesController : ApiController
    {
        AppDbContext data = AppDbContext.Create();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public int Get(int id)
        {
            return id;
        }

        [HttpGet]
        public bool VerifyUser(string username, string password)
        {

            var user = data.Users.FirstOrDefault(u => u.Username == username && u.PassHash == password);     

            return user != null;
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
    }
}