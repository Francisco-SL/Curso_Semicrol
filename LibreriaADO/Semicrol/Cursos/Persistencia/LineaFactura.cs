namespace Semicrol.Cursos.PersistenciaADO
{
    public class LineaFactura
    {
        public LineaFactura(int numero, Factura factura, string producto, int unidades)
        {
            Numero = numero;
            Factura = factura;
            Producto = producto;
            Unidades = unidades;
        }

        public LineaFactura(int numero, Dominio.Factura factura, int unidades)
        {
            Numero = numero;
            Unidades = unidades;
        }

        public int Numero { get; set; }
        public Factura Factura { get; set; }
        public string Producto { get; set; }
        public int Unidades { get; set; }

        public override string ToString() => "Linea: " + Numero + "\tProducto: " + Producto + "\tUnidades: " + Unidades;
    }
}
