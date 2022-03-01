using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using acessopeliculas;

namespace serviciospelicula.Controllers
{
    public class PelisController : ApiController
    {
        public IEnumerable<peliculas> Get()
        {
            using (peliculasEntities entities = new peliculasEntities())
            {
                return entities.peliculas.ToList();

            }



        }



    }
}
