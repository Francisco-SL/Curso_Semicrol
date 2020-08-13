namespace Semicrol.Cursos.Persistencia.Filtros
{
    public class FiltroFacturaNuevo
    {
        private int _numero;
        private string _concepto;

        public FiltroFacturaNuevo()
        {

        }

        public int Numero
        {
            get
            {
                return _numero;
            }
        }

        public string Concepto
        {
            get
            {
                return _concepto;
            }
        }

        // programacion fluida
        public FiltroFacturaNuevo AddNumero(int num)
        {
            _numero = num;
            return this;
        }

        public FiltroFacturaNuevo AddConcepto(string conc)
        {
            this._concepto = conc;
            return this;
        }

    }
}
