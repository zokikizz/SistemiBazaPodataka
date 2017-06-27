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
    public class ZaposleniController : ApiController
    {
        // GET: api/Zaposleni
        public JsonResult<IEnumerable<zaposleni>> Get()
        {
            IEnumerable<zaposleni> z = APIBaza.GetEntities<zaposleni>();
            return Json(z);
        }

        // GET: api/Zaposleni/5
        public JsonResult<zaposleni> Get(int id)
        {
            zaposleni n = APIBaza.GetEntity<zaposleni>(id);
            return Json(n);
        }

        // POST: api/Zaposleni
        public JsonResult<bool> Post([FromBody]zaposleni value)
        {
            APIBaza.AddEntity<zaposleni>(value, false);
            return Json(true);
        }

        // PUT: api/Zaposleni/5
        public JsonResult<bool> Put(int id, [FromBody]zaposleni value)
        {
            APIBaza.UpdateEntity<zaposleni>(id, value);
            return Json(true);
        }

        // DELETE: api/Zaposleni/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<zaposleni>(id);
            return Json(true);
        }
    }
}
