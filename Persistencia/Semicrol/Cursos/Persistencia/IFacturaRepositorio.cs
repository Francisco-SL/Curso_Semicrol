using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia.Filtros;
using System.Collections.Generic;

namespace Semicrol.Cursos.Persistencia
{
    interface IFacturaRepositorio
    {
        void Insertar(Factura f);
        void Actualizar(Factura f);
        void Borrar(Factura f);
        List<Factura> BuscarTodos();
        List<Factura> BuscarTodos(FiltroFacturaNuevo ffn);
        Factura BuscarUno(int num);

    }
}
