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
    public class FotografijaController : ApiController
    {
        // GET: api/Fotografija
        public JsonResult<IEnumerable<fotografija>> Get()
        {
            IEnumerable<fotografija> z = APIBaza.GetEntities<fotografija>();
            return Json(z);
        }

        // GET: api/Fotografija/5
        public JsonResult<fotografija> Get(int id)
        {
            fotografija n = APIBaza.GetEntity<fotografija>(id);
            return Json(n);
        }

        // POST: api/Fotografija
        public JsonResult<bool> Post([FromBody]fotografija value)
        {
            APIBaza.AddEntity<fotografija>(value, false);
            return Json(true);
        }

        // PUT: api/Fotografija/5
        public JsonResult<bool> Put(int id, [FromBody]fotografija value)
        {
            APIBaza.UpdateEntity<fotografija>(id, value);
            return Json(true);
        }

        // DELETE: api/Fotografija/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<fotografija>(id);
            return Json(true);
        }
    }
}
