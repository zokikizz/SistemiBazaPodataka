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
    public class KlijentTelefonController : ApiController
    {
        // GET: api/KlijentTelefon
        public JsonResult<IEnumerable<klijentTelefon>> Get()
        {
            IEnumerable<klijentTelefon> z = APIBaza.GetEntities<klijentTelefon>();
            return Json(z);
        }


        // GET: api/KlijentTelefon/5
        public JsonResult<klijentTelefon> Get(int id)
        {
            klijentTelefon n = APIBaza.GetEntity<klijentTelefon>(id);
            return Json(n);
        }

        // POST: api/KlijentTelefon
        public JsonResult<bool> Post([FromBody]klijentTelefon value)
        {
            APIBaza.AddEntity<klijentTelefon>(value, false);
            return Json(true);
        }

        // PUT: api/KlijentTelefon/5
        public JsonResult<bool> Put(int id, [FromBody]klijentTelefon value)
        {
            APIBaza.UpdateEntity<klijentTelefon>(id, value);
            return Json(true);
        }

        // DELETE: api/KlijentTelefon/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<klijentTelefon>(id);
            return Json(true);
        }
    }
}
