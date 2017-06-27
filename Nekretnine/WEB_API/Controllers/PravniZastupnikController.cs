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
    public class PravniZastupnikController : ApiController
    {
        // GET: api/PravniZastupnik
        public JsonResult<IEnumerable<pravniZastupnik>> Get()
        {
            IEnumerable<pravniZastupnik> z = APIBaza.GetEntities<pravniZastupnik>();
            return Json(z);
        }

        // GET: api/PravniZastupnik/5
        public JsonResult<pravniZastupnik> Get(int id)
        {
            pravniZastupnik n = APIBaza.GetEntity<pravniZastupnik>(id);
            return Json(n);
        }

        // POST: api/PravniZastupnik
        public JsonResult<bool> Post([FromBody]pravniZastupnik value)
        {
            APIBaza.AddEntity<pravniZastupnik>(value, false);
            return Json(true);
        }

        // PUT: api/PravniZastupnik/5
        public JsonResult<bool> Put(int id, [FromBody]pravniZastupnik value)
        {
            APIBaza.UpdateEntity<pravniZastupnik>(id, value);
            return Json(true);
        }

        // DELETE: api/PravniZastupnik/5
        public JsonResult<bool> Delete(int id)
        {
            APIBaza.RemoveEntity<pravniZastupnik>(id);
            return Json(true);
        }
    }
}
