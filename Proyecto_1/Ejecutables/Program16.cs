using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program16
    {
        static void Main(string[] args)
        {
            Compra c1 = new Compra(1, "Concepto 1");
            c1.AddLineaDeCompra(new LineaDeCompra(1, 586.21, "Ordenadores"));
            c1.AddLineaDeCompra(new LineaDeCompra(2, 12.45, "Alimentos"));
            Console.WriteLine("Compra: {0} \t\t Id: {1} \t\t Importe: {2} \t\t IVA21: {3}", c1.Concepto, c1.Id, c1.Importe, c1.ImporteConIVA());
            Console.WriteLine("Contenido:");
            foreach (LineaDeCompra lndc in c1.LineaCompra)
            {
                Console.WriteLine("Id: {0} \t\t Concepto: {1} \t\t Importe: {2} \t\t IVA21: {3}", lndc.Id, lndc.Concepto, lndc.Importe, lndc.IVA21());
            }
            Console.ReadLine();
        }
    }
}
