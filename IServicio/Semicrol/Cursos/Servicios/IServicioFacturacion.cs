using Semicrol.Cursos.Dominio;
using System.Collections.Generic;
using Semicrol.Cursos.Persistencia.Filtros;

namespace Semicrol.Cursos.Servicios
{
   public interface IServicioFacturacion
    {
        void InsertarFactura(Factura f);
        List<Factura> ListarFacturas();
        void BorrarFactura(Factura f);
        void ActualizarFactura(Factura f);
        void InsertarLineaFactura(LineaFactura lnf);
        void BorrarLineaFactura(LineaFactura lnf);
        void ActualizarLineaFactura(LineaFactura lnf);
        List<Factura> BuscarFacturaFiltro(FiltroFacturaNuevo f);        
       List<LineaFactura> ListarLineasFactura();
        Factura BuscarFactura(int f);

    }
}
