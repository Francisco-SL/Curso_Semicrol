using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.InterfaceCocina
{
    class Bombilla : IEncendible
    {
        public void Apagar()
        {
            Console.WriteLine("La {0} se apaga", GetType().Name);
        }

        public void Encender()
        {
            Console.WriteLine("La {0} se enciende", GetType().Name);
        }
    }
}
