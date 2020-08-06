using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class Monitor
    {


        public Monitor(int pulgadas)
        {
            Pulgadas = pulgadas;
        }

        public int Pulgadas { get; set; }

        public void Encender()
        {
            Console.WriteLine("El monitor se enciende");
        }

        public void Apagar()
        {
            Console.WriteLine("El monitor se apaga");
        }
    }
}
