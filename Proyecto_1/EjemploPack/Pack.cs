using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EjemploPack
{
    class Pack<T,K> where T : IPrecio where K : IPrecio
    {

        public Pack(T producto1, K producto2)
        {
            Producto1 = producto1;
            Producto2 = producto2;
        }

        public T Producto1 { get; set; }
        public K Producto2 { get; set; }

        public double ImporteTotal()
        {       
            return Math.Round(Producto1.Importe + Producto2.Importe,2);
        }

    }
}
