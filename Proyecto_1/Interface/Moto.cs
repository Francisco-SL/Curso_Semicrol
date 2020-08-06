using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Interface
{
    class Moto : IConducible
    {
        public void Arracar()
        {
            Console.WriteLine("La {0} arranca", GetType().Name);
        }

        public void Avanzar()
        {
            Console.WriteLine("La {0} avanza", GetType().Name);
        }

        public void Girar()
        {
            Console.WriteLine("La {0} gira", GetType().Name);
        }

        public void Parar()
        {
            Console.WriteLine("La {0} para", GetType().Name);
        }
    }
}
