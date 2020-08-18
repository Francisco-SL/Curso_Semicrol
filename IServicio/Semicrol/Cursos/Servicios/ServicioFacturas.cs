using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.Persistencia.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Cursos.Servicios
{
    public class ServicioFacturas : IServicioFacturacion
    {
        private IFacturaRepositorio repoFacturas = new FacturaRepository();
        private ILineasFacturaRepository repoLineasFactura = new LineaFacturaRepository();

        public void ActualizarFactura(Factura f)
        {
            repoFacturas.Actualizar(f);
        }

        public void ActualizarLineaFactura(LineaFactura lnf)
        {
            repoLineasFactura.ActualizarUnidadesLinea(lnf);
        }

        public void BorrarFactura(Factura f)
        {
            repoFacturas.Borrar(f);
        }

        public void BorrarLineaFactura(LineaFactura lnf)
        {
            repoLineasFactura.Eliminar(lnf);
        }

        public Factura BuscarFactura(int f)
        {
            return repoFacturas.BuscarUno(f);
        }

        public List<Factura> BuscarFacturaFiltro(FiltroFacturaNuevo f)
        {
            return repoFacturas.BuscarTodos(f);
        }

        public void InsertarFactura(Factura f)
        {
            repoFacturas.Insertar(f);
            foreach (LineaFactura lf in f.LineasFactura)
            {
                repoLineasFactura.Insertar(lf);
            }
        }

        public void InsertarLineaFactura(LineaFactura lnf)
        {
            repoLineasFactura.Insertar(lnf);
        }

        public List<LineaFactura> ListarLineasFactura()
        {
            return repoLineasFactura.BuscarTodos();
        }

        public List<Factura> ListarFacturas()
        {
            return repoFacturas.BuscarTodos();
        }
    }
}