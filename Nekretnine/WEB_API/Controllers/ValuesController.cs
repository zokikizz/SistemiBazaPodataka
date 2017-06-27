using Prodavnica;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace WEB_API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public JsonResult<IEnumerable<notar>> Get()
        {
            IEnumerable<notar> n = APIBaza.GetEntities<notar>();
            return Json(n);
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
