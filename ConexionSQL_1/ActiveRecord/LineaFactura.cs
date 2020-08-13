using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;
namespace ConexionSQL_1.Clases
{
    class LineaFactura
    {
        static void Main(string[] args)
        {
            Buscar();
            Console.ReadLine();
        }

        public static void MostrarTodas()
        {
            List<LineaFacturaAR> list = LineaFacturaAR.BuscarTodos();
            if (list.Count != 0)
            {
                Console.WriteLine("Lista:");
                foreach (LineaFacturaAR fac in list)
                {
                    Console.WriteLine(fac.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nada");
            }
        }

        public static void Buscar()
        {
            FacturaActiveRecord f = new FacturaActiveRecord(2);
            List<LineaFacturaAR> lista = LineaFacturaAR.LineasDeFactura(f);
            if (lista.Count != 0)
            {
                Console.WriteLine("Factura: {0} ({1})", f.Concepto, f.Numero);
                foreach (LineaFacturaAR lfar in lista)
                {
                    Console.WriteLine(lfar.ToString());
                }
            }
            else
            {
                Console.WriteLine("No encuentra datos");
            }
        }

    }
}
