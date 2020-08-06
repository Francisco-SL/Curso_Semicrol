using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.InterfaceCocina
{
    class BombillaSmart : Bombilla, IEncendibleSmart
    {
        public void ApagarVoz()
        {
            Console.WriteLine("La {0} se apaga por voz", GetType().Name);
        }

        public void EncenderVoz()
        {
            Console.WriteLine("La {0} se enciende por voz", GetType().Name);
        }
    }
}
