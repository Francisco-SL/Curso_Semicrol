using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program10
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(4, 6);
            Console.WriteLine("El rectangulo 1: l1: {0}, l2: {1}", r1.Lado1, r1.Lado2);
            Console.WriteLine("Area del rectangulo 1: {0}", r1.Area());
            Console.WriteLine("Perimetro del rectangulo 1: {0}", r1.Perimetro());
            Console.ReadLine();
        }
    }
}
