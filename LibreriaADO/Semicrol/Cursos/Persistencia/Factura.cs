namespace Semicrol.Cursos.PersistenciaADO
{
    public class Factura
    {
        public Factura(int numero)
        {
            Numero = numero;
        }

        public Factura(int numero, string concepto)
        {
            Numero = numero;
            Concepto = concepto;
        }

        public int Numero { get; set; }
        public string Concepto { get; set; }
        public override string ToString() => "Factura: " + Concepto + " (" + Numero + ")";
    }
}