using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1
{
    class Program17
    {
        static void Main(string[] args)
        {
            Televisor t = new Televisor();
            t.NumeroSerie = 32461523;
            t.Pulgadas = 50;
            t.Encender();

            Console.ReadLine();
        }
    }
}
