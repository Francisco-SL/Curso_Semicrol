using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia;
namespace Semicrol.Cursos.Persistencia
{
    public interface ILineasFacturaRepository
    {
         void Insertar(LineaFactura lf);
         void Eliminar(LineaFactura f);
         void ActualizarUnidadesLinea(LineaFactura f);
         List<LineaFactura> BuscarTodos();
                   }
}
