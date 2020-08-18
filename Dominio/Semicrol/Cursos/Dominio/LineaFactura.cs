using System;
using System.Collections.Generic;
using System.Text;

namespace Semicrol.Cursos.Dominio
{
    public class LineaFactura
    {

        public LineaFactura(int numero, string producto, int unidades)
        {
            Numero = numero;
            Producto = producto;
            Unidades = unidades;
        }

        public LineaFactura(int numero, int unidades)
        {
            Numero = numero;
            Unidades = unidades;
        }

        public LineaFactura()
        {
        }

        public LineaFactura(int numero, string producto, int unidades, Factura factura) {
            Numero = numero;
            Producto = producto;
            Unidades = unidades;
            Factura = factura;
        }

        public int Numero { get; set; }
        public string Producto { get; set; }
        public int Unidades { get; set; }
        public Factura Factura { get; set; }

        public override string ToString() => "Linea: " + Numero + "\tProducto: " + Producto + "\tUnidades: " + Unidades;

        public override bool Equals(object obj)
        {
            var factura = obj as LineaFactura;
            return factura != null &&
                   Numero == factura.Numero;
        }

        public override int GetHashCode()
        {
            return -1449941195 + Numero.GetHashCode();
        }
    }
}
