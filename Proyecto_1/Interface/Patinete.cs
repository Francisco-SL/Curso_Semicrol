using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Interface
{
    class Patinete : IConducibleConectable//IConducible, IConectable
    {
        public void Arracar()
        {
            Console.WriteLine("El {0} arranca", GetType().Name);
        }

        public void Avanzar()
        {
            Console.WriteLine("El {0} avanza", GetType().Name);
        }

        public void Conectar()
        {
            Console.WriteLine("El {0} se conecta", GetType().Name);
        }

        public void Desconectar()
        {
            Console.WriteLine("El {0} se desconecta", GetType().Name);
        }

        public void Girar()
        {
            Console.WriteLine("El {0} gira", GetType().Name);
        }

        public void Parar()
        {
            Console.WriteLine("El {0} para", GetType().Name);
        }
    }
}
