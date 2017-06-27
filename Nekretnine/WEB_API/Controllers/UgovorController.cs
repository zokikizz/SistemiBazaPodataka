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
    public class UgovorController : ApiController
    {
        // GET: api/Ugovor
        public JsonResult<IEnumerable<ugovor>> Get()
        {
            IEnumerable<ugovor> z = APIBaza.GetEntities<ugovor>();
            return Json(z);
        }

        // GET: api/Ugovor/5
        public JsonResult<ugovor> Get(int id)
        {
            ugovor n = APIBaza.GetEntity<ugovor>(id);
            return Json(n);
        }

        // POST: api/Ugovor
        public JsonResult<bool> Post([FromBody]ugovor value)
        {
            APIBaza.AddEntity<ugovor>(value, false);
            return Json(true);
        }

        // PUT: api/Ugovor/5
        public JsonResult<bool> Put(int id, [FromBody]ugovor value)
        {
            APIBaza.UpdateEntity<ugovor>(id, value);
            return Json(true);
        }

        // DELETE: api/Ugovor/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<ugovor>(id);
            return Json(true);
        }
    }
}
