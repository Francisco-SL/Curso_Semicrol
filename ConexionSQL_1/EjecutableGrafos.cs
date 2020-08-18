using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia;
using System;
using System.Collections.Generic;

namespace ConexionSQL_1.Persistencia
{
    class EjecutableGrafos
    {

        static void Main(string[] args)
        {
            FacturaRepository repo = new FacturaRepository();

            List<Factura> lista = repo.BuscarTodosLineas();
            if (lista.Count != 0)
                foreach (Factura f in lista)
                {
                    Console.WriteLine(f.ToString());
                    foreach (LineaFactura lf  in f.LineasFactura)
                    {
                        Console.WriteLine("|--- {0}", lf.ToString());
                    }
                    Console.WriteLine();
                }
            else
                Console.WriteLine("No hay nada");
            Console.ReadLine();
        }
    }
}
