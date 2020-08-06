using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
using Proyecto_1.EmpresaAlquiler;
namespace Proyecto_1
{
    class Program20
    {
        static void Main(string[] args)
        {
            Empresa e = new Empresa(1, "Empresa 1");
            Alquiler a1 = new AlquilerJoven(1, 200);
            Alquiler a2 = new AlquilerJoven(2, 300);
            Alquiler a3 = new AlquilerJoven(3, 400);
            Alquiler a4 = new AlquilerVIP(4, 500);
            e.AddAlquiler(a1);
            e.AddAlquiler(a2);
            e.AddAlquiler(a3);
            e.AddAlquiler(a4);
            Console.WriteLine("El importe total de la empresa {0} es de {1}", e.Nombre, Math.Round(e.obtenerTotal(), 2));
            Console.WriteLine("Listado de Alquileres");
            e.ListarAlquiler();
            Alquiler a = e.importeMayor();
            Console.WriteLine("El alquiler con mayor importe es: ID: {0}, Importe: {1}", a.Numero, Math.Round(a.ImporteTotal(), 2));
            Console.WriteLine("Cantidad de alquileres: {0}",e.NumeroAlquileres());
            e.EliminarAlquiler(a1);
            Console.WriteLine("Cantidad de alquileres tras eliminar: {0}", e.NumeroAlquileres());
            Console.WriteLine("¿Existe a1?: {0}", e.ContieneAlquiler(a1) == true ? "Si" : "No");
            Console.WriteLine("¿Existe a2?: {0}", e.ContieneAlquiler(a2) == true ? "Si" : "No");
            Console.ReadLine();
        }
    }
}
