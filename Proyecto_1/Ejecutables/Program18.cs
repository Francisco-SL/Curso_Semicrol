using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1
{
    class Program18
    {
        static void Main(string[] args)
        {
            Ordenador o = new Ordenador(new CPU("Intel i7", "16"), new Monitor(55));
            o.Encender();
            Portatil prt = new Portatil(new CPU("Intel i7", "16"));

            prt.Encender();
            Console.ReadLine();
        }
    }
}
