using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class ListarDatos
    {
        static void Main(string[] args)
        {
            List<FacturaActiveRecord> list = FacturaActiveRecord.BuscarTodos();
            Console.WriteLine("Lista:");
            foreach (FacturaActiveRecord fac in list)
            {
                Console.WriteLine(fac.ToString());
            }
            Console.ReadLine();
        }
    }
}
