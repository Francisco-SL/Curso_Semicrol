using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EnchufeSmart
{
    class ComparadorPotencia : IComparer<Frigorifico>
    {
        public int Compare(Frigorifico x, Frigorifico y)
        {
            if (x.Potencia > y.Potencia)
            {
                return 1;
            }else if (x.Potencia == y.Potencia)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
