using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia;
using System;
using System.Collections.Generic;
using Semicrol.Cursos.Servicios;

namespace ConexionSQL_1.Persistencia
{
    class EjecutableISERVICIO
    {

        static void Main(string[] args)
        {
            IFacturaRepositorio repoFactura = new FacturaRepository();
            ILineasFacturaRepository repoLineas = new LineaFacturaRepository();
            IServicioFacturacion servicio = new ServicioFacturas();
            List<Factura> lista = servicio.ListarFacturas();
            if (lista.Count != 0)
                foreach (Factura f in lista)
                    Console.WriteLine(f.ToString());
            else
                Console.WriteLine("No hay nada");
            Console.ReadLine();
        }
    }
}
