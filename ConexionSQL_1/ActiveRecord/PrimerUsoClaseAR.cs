using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;
namespace ConexionSQL_1
{
    class PrimerUsoClaseAR
    {
        static void Main(string[] args)
        {
            FacturaActiveRecord f = new FacturaActiveRecord(3, "OtraAgain");
            f.Insertar();
            f.Eliminar();
            Console.ReadLine();
        }
    }
}
