using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1
{
    public class FacturasController : ApiController
    {

        static List<Factura> Facturas = new List<Factura>();

        static FacturasController()
        {
            Facturas.Add(new Factura(1, "Ordenador"));
            Facturas.Add(new Factura(2, "Tablet"));
        }
        
        // GET api/<controller>
        public IList<Factura> Get()
        {
            return Facturas;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Factura f)
        {
            Facturas.Add(f);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}