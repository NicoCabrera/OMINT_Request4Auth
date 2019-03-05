using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OMINT_Request4Auth.Controllers
{
    public class ElegibilidadController : ApiController
    {
        // GET api/Elegibilidad
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Elegibilidad/5
        public string Get(int id)
        {
            return "Soy el texto favorito";
        }

        // POST api/Elegibilidad
        public void Post([FromBody]string value)
        {

        }

        // PUT api/Elegibilidad/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Elegibilidad/5
        public void Delete(int id)
        {

        }
    }
}