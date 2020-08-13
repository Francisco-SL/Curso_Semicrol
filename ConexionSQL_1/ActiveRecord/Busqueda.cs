using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;
namespace ConexionSQL_1
{
    class Busqueda
    {
        static void Main(string[] args)
        {
            FacturaActiveRecord f = FacturaActiveRecord.Buscar(92);
            if (f != null)            
                Console.WriteLine("Factura encontrada:\nNumero: {0}\tConcepto: {1}", f.Numero, f.Concepto);            
            Console.ReadLine();
        }
    }
}
