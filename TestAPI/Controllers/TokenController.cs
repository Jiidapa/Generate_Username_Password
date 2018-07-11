using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Models;
using TestAPI.TestApiEntities;
using TestAPI.Helper;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class TokenController : ApiController
    {
        protected GenerateUserPassHelper genHelp = new GenerateUserPassHelper();
        // GET: api/Token
        public IHttpActionResult Get()
        {
            var gen = genHelp.GenerateUsernamePassword();
            return Json(gen);
        }

        // GET: api/Token/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Token
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Token/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Token/5
        public void Delete(int id)
        {
        }

    }
}
