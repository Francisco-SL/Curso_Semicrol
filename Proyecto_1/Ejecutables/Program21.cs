using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
using Proyecto_1.EmpresaAlquiler;
namespace Proyecto_1
{
    class Program21
    {
        static void Main(string[] args)
        {
            bool verdadero = true;
            Boolean otroVerdadero = verdadero;//inboxing
            bool otroMasVerdadero = otroVerdadero;//outboxing
            Console.WriteLine(verdadero);
            int numero = 7;
            Console.WriteLine(numero);
            Int32 numero2 = 2000;
            Console.WriteLine(numero2);
            int numero3 = Int32.Parse("30");
            Console.WriteLine(numero3 + 1);
            List<Int32> listaNumeros = new List<int>();
            listaNumeros.Add(5);
            listaNumeros.Add(67);
            listaNumeros.Add(2);
            listaNumeros.Add(46);
            foreach(Int32 n in listaNumeros)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
