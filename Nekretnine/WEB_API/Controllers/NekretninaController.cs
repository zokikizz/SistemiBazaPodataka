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
    public class NekretninaController : ApiController
    {
        // GET: api/Nekretnina
        public JsonResult<IEnumerable<nekretnina>> Get()
        {
            IEnumerable<nekretnina> z = APIBaza.GetEntities<nekretnina>();
            return Json(z);
        }

        // GET: api/Nekretnina/5
        public JsonResult<nekretnina> Get(int id)
        {
            nekretnina n = APIBaza.GetEntity<nekretnina>(id);
            return Json(n);
        }

        // POST: api/Nekretnina
        public JsonResult<bool> Post([FromBody]nekretnina value)
        {
            APIBaza.AddEntity<nekretnina>(value, false);
            return Json(true);
        }

        // PUT: api/Nekretnina/5
        public JsonResult<bool> Put(int id, [FromBody]nekretnina value)
        {
            APIBaza.UpdateEntity<nekretnina>(id, value);
            return Json(true);
        }

        // DELETE: api/Nekretnina/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<nekretnina>(id);
            return Json(true);
        }
    }
}
