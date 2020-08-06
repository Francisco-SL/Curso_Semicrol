using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class LineaDeCompra
    {
        public LineaDeCompra(int id, double importe, string concepto)
        {
            Id = id;
            Importe = importe;
            Concepto = concepto;
        }

        public int Id { get; set; }
        public double Importe { get; set; }
        public string Concepto { get; set; }

        public double IVA21()
        {
            return Importe * 1.21;
        }
    }
}
