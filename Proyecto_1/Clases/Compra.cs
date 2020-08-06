using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Compra
    {
        public int Id { get; set; } 
        public string Concepto { get;  set; }
        List<LineaDeCompra> listaLineaCompra = new List<LineaDeCompra>();

        public Compra(int id, string concepto)
        {
            Id = id;
            Concepto = concepto;
        }

        public List<LineaDeCompra> LineaCompra
        {
            get
            {
                return listaLineaCompra;
            }

            set
            {
                listaLineaCompra = value;
            }
        }

        public void AddLineaDeCompra(LineaDeCompra lndc)
        {
            LineaCompra.Add(lndc);
        }

        public double Importe
        {
            get
            {
                double tot = 0;
                foreach(LineaDeCompra lndc in LineaCompra)
                {
                    tot += lndc.Importe;
                }
                return tot;
            }
        }


        public double ImporteConIVA()
        {
            double total = 0;
            foreach(LineaDeCompra lndc in LineaCompra)
            {
                total += lndc.IVA21();
            }
            return total;
        }
    }
}
