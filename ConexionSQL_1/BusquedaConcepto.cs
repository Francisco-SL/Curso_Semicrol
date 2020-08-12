using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;
namespace ConexionSQL_1
{
    class BusquedaConcepto
    {
        static void Main(string[] args)
        {         
            List<FacturaActiveRecord> list = FacturaActiveRecord.BuscarConcepto("Compra A");
            if (list.Count != 0)
            {
                Console.WriteLine("Lista:");
                foreach (FacturaActiveRecord fac in list)
                {
                    Console.WriteLine(fac.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nada");
            }
            
            Console.ReadLine();
        }
    }
}
