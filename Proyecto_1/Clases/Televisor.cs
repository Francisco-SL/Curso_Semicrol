using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class Televisor : Electrodomestico
    {
        public int Pulgadas { get; set; }

        public override void Encender()
        {
            Console.WriteLine("El televisor se enciende");
        }

        public override void Apagar()
        {
            Console.WriteLine("El televisor se apaga");
        }
    }
}
