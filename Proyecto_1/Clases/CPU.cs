using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class CPU
    {
        public CPU(string procesador, string rAM)
        {
            Procesador = procesador;
            RAM = rAM;
        }

        public string Procesador { get; set; }
        public string RAM { get; set; }

        public void Encender()
        {
            Console.WriteLine("El CPU se enciende");
        }

        public void Apagar()
        {
            Console.WriteLine("El CPU se apaga");
        }
    }
}
