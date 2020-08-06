using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.InterfaceCocina
{
    class Frigorifico : IEncendible
    {
        
        public void Apagar()
        {
            Console.WriteLine("El {0} se apaga", GetType().Name);
        }

        public void Encender()
        {
            Console.WriteLine("El {0} se enciende", GetType().Name);
        }
    }
}
