using System.Collections.Generic;

namespace Semicrol.Cursos.PersistenciaADO
{
    public interface IFacturaRepositorio
    {
        void Insertar(Factura f);
        void Actualizar(Factura f);
        void Borrar(Factura f);
        List<Factura> BuscarTodos();
        List<Factura> BuscarTodos(FiltroFacturaNuevo ffn);
        Factura BuscarUno(int num);

    }
}
