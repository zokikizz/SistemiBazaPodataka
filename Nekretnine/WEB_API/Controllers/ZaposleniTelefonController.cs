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
    public class ZaposleniTelefonController : ApiController
    {
        // GET: api/ZaposleniTelefon
        public JsonResult<IEnumerable<zaposleniTelefon>> Get()
        {
            IEnumerable<zaposleniTelefon> z = APIBaza.GetEntities<zaposleniTelefon>();
            return Json(z);
        }

        // GET: api/ZaposleniTelefon/5
        public JsonResult<zaposleniTelefon> Get(int id)
        {
            zaposleniTelefon n = APIBaza.GetEntity<zaposleniTelefon>(id);
            return Json(n);
        }

        // POST: api/ZaposleniTelefon
        public JsonResult<bool> Post([FromBody]zaposleniTelefon value)
        {
            APIBaza.AddEntity<zaposleniTelefon>(value, false);
            return Json(true);
        }

        // PUT: api/ZaposleniTelefon/5
        public JsonResult<bool> Put(int id, [FromBody]zaposleniTelefon value)
        {
            APIBaza.UpdateEntity<zaposleniTelefon>(id, value);
            return Json(true);
        }

        // DELETE: api/ZaposleniTelefon/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<zaposleniTelefon>(id);
            return Json(true);
        }
    }
}
