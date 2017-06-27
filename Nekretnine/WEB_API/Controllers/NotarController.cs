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
    public class NotarController : ApiController
    {
        // GET: api/Notar radi
        public JsonResult<IEnumerable<notar>> GetNotare()
        {
            IEnumerable<notar> n = APIBaza.GetEntities<notar>();
            return Json(n);
        }

        // GET: api/Notar/5 radi
        public JsonResult<notar> Get(int id)
        {
            notar n = APIBaza.GetEntity<notar>(id);
            return Json(n);
        }

        // POST: api/Notar radi
        public JsonResult<bool> Post([FromBody]notar value)
        {
            APIBaza.AddEntity<notar>(value, false);
            return Json(true);
        }

        // PUT: api/Notar/5 radi
        public JsonResult<bool> Put(int id, [FromBody]notar value)
        {
            APIBaza.UpdateEntity<notar>(id, value);
            return Json(true);
        }

        // DELETE: api/Notar/5 
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<notar>(id);
            return Json(true);
        }
    }
}
