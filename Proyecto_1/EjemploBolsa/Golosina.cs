using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EjemploBolsa
{
    class Golosina : IPrecio
    {
        public Golosina(string sabor, double importe)
        {
            Sabor = sabor;
            Importe = importe;
        }

        public string Sabor { get; set; }
        public double Importe { get; set; }
    }
}
