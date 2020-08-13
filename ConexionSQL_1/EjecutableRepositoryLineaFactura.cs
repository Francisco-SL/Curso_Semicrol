using Semicrol.Cursos.Dominio;
using System;
using System.Collections.Generic;
using Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.Persistencia.Filtros;
namespace ConexionSQL_1.Persistencia
{
    class EjecutableRepositoryLineaFactura
    {
        public static LineaFacturaRepository repositorio = new LineaFacturaRepository();

        static void Main(string[] args)
        {
           // Insertar();
            BuscarTodas();
            Console.ReadLine();
        }

        public static void Insertar()
        {
            repositorio.Insertar(new LineaFactura(5, new Factura(1), "Leche", 5));
        }
        public static void BuscarTodas()
        {
            List<LineaFactura> lista = repositorio.BuscarTodos();
            foreach (LineaFactura f in lista)
            {
                Console.WriteLine(f.ToString());
            }
            if (lista.Count == 0)
                Console.WriteLine("No hay nada");
        }
    }
}
