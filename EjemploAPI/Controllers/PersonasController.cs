using EjemploAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EjemploAPI.Controllers
{
    public class PersonasController : ApiController
    {
        Persona[] Personas = new Persona[]
        {
            new Persona { Nombre="Miguel", Apellidos="Garcia", Edad=33 },
            new Persona { Nombre="Eva", Apellidos="Gonzalez", Edad=44 },
            new Persona { Nombre="Pedro", Apellidos="Martinez", Edad=0 }
        };

        public IEnumerable<Persona> GetAllProducts()
        {
            return Personas;
        }

        public IHttpActionResult GetProduct(string nom)
        {
            var per = Personas.FirstOrDefault((p) => p.Nombre.Equals(nom));
            return Ok(per);
        }
    }
}
