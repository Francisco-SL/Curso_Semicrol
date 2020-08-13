using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.Persistencia.Filtros;

namespace ConexionSQL_1.Persistencia
{
    class EjecutableRepositoryFactura
    {
        public static FacturaRepository repositorio = new FacturaRepository();

        static void Main(string[] args)
        {
            BusquedaFiltro();
            Console.ReadLine();
        }

        public static void Insertar()
        {
            repositorio.Insertar(new Factura(3, "Concepto"));
        }

        public static void Eliminar()
        {
            repositorio.Borrar(new Factura(3));
        }

        public static void BuscarTodas()
        {
            List<Factura> lista = repositorio.BuscarTodos();
            foreach (Factura f in lista)
            {
                Console.WriteLine(f.ToString());
            }
            if (lista.Count == 0)
                Console.WriteLine("No hay nada");                
        }

        public static void BuscarUna()
        {
            Factura f = repositorio.BuscarUno(1);
            if (f != null)
                Console.WriteLine(f.ToString());
            else
                Console.WriteLine("No hay nada");
        }

        public static void ActualizarConcepto()
        {
            repositorio.Actualizar(new Factura(2, "Nuevo Concepto"));
        }

       public static void BusquedaFiltro()
        {
            FiltroFacturaNuevo ff = new FiltroFacturaNuevo().AddNumero(1);
            List<Factura> lista = repositorio.BuscarTodos(ff);
            if (lista.Count != 0)
                foreach (Factura f in lista)
                {
                    Console.WriteLine(f.ToString());
                }
            else
                Console.WriteLine("No hay nada");
        }
    }
}
