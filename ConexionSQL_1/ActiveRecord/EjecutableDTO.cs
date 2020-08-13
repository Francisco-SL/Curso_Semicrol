using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class EjecutableDTO
    {
        static void Main(string[] args)
        {
            List<FacturaLineaDTO> lista = FacturaLineaDTO.UnidadesTotalesPorFactura();
            if (lista.Count != 0)
            {
                foreach (FacturaLineaDTO lfar in lista)
                {
                    Console.WriteLine("Concepto: {0}\tUnidades totales: {1}", lfar.Concepto, lfar.Unidades);
                }
            }
            else
            {
                Console.WriteLine("No encuentra datos");
            }
            Console.ReadLine();
        }
    }
}
