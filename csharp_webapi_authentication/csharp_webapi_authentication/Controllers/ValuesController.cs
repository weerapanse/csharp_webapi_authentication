using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace csharp_webapi_authentication.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var user1 = RequestContext.Principal.Identity.IsAuthenticated.ToString();
            var user2 = RequestContext.Principal.Identity.AuthenticationType;
            var user3 = RequestContext.Principal.Identity.Name;
            return new string[] { "value1", "value2", user1, user2, user3 };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
