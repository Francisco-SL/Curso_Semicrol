using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto_1.Clases;
namespace Proyecto_1.EmpresaAlquiler
{
    class AlquilerVIP : Alquiler
    {
        public AlquilerVIP(int numero, double importe) : base(numero, importe)
        {
        }

        public override double ImporteTotal()
        {
            return base.ImporteTotal()+200;
        }
    }
}
