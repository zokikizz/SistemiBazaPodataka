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
    public class KlijentiController : ApiController
    {
        // GET: api/Klijenti
        public JsonResult<IEnumerable<klijenti>> Get()
        {
            IEnumerable<klijenti> z = APIBaza.GetEntities<klijenti>();
            return Json(z);
        }

        // GET: api/Klijenti/5
        public JsonResult<klijenti> Get(int id)
        {
            klijenti n = APIBaza.GetEntity<klijenti>(id);
            return Json(n);
        }

        // POST: api/Klijenti
        public JsonResult<bool> Post([FromBody]klijenti value)
        {
            APIBaza.AddEntity<klijenti>(value, false);
            return Json(true);
        }

        // PUT: api/Klijenti/5
        public JsonResult<bool> Put(int id, [FromBody]klijenti value)
        {
            APIBaza.UpdateEntity<klijenti>(id, value);
            return Json(true);
        }

        // DELETE: api/Klijenti/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<klijenti>(id);
            return Json(true);
        }
    }
}
