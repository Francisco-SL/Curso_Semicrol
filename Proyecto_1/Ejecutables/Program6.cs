using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program6
    {
        static void Main(string[] args)
        {
            double resultado = sumarNumeros(1, 4);
            Console.WriteLine(resultado);
            double resultado2 = sumarNumeros(324, 4365);
            Console.WriteLine(resultado2);
            Console.ReadLine();
        }

        static double sumarNumeros(double a, double b)
        {
            return a+b;
        }
    }
}
