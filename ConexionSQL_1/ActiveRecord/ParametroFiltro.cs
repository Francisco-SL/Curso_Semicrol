using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class ParametroFiltro
    {
        static void Main(string[] args)
        {
            FiltroFactura f = new FiltroFactura();
            // f.Concepto = "NUEVA FAC";
            f.Numero = 2;
            List<FacturaActiveRecord> list = FacturaActiveRecord.BuscarTodos(f);
            if (list.Count != 0)
            {
                Console.WriteLine("Encontrado:");
                foreach (FacturaActiveRecord fac in list)
                {
                    Console.WriteLine(fac.ToString());
                }
            }
            else
            {
                Console.WriteLine("No se ha encontrado nada");
            }
            Console.ReadLine();
        }
    }
}
