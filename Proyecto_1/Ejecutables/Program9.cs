using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program9
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(5, "ordenador", 500);
            Factura f2 = new Factura { Numero = 5, Concepto = "Ejemplo 2", Importe = 501 };
            //f1.Numero = 1;
            //f1.Concepto = "Factura nº " + f1.Numero;
            //f1.Importe = 654.54;
            Console.WriteLine("Concepto: " + f1.Concepto);
            Console.WriteLine("Importe: " + f1.Importe);
            Console.WriteLine("Importe con IVA: " + f1.ImporteConIVA(21));
            Console.ReadLine();
        }
    }
}
