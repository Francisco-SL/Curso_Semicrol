using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Factura
    {
        public int Numero { get; set; }
        public string Concepto { get; set; }

        public Factura(int numero, string concepto)
        {
            Numero = numero;
            Concepto = concepto;
        }

        public Factura()
        {

        }
    }
}