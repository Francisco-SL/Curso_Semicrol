using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Factura
    {
        private int _numero;
        private string _concepto;
        private double _importe;

        public Factura()
        {

        }

        public Factura(int numero, string concepto, double importe)
        {
            _numero = numero;
            _concepto = concepto;
            _importe = importe;
        }

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        public string Concepto
        {
            get
            {
                return _concepto;
            }
            set
            {
                _concepto = value;
            }
        }
        public double Importe
        {
            get
            {
                return _importe;
            }
            set
            {
                _importe = value;
            }
        }

        public double ImporteConIVA( )
        {
            return this.Importe *1.21;
        }

        public double ImporteConIVA(int porcentaje)
        {
            return this.Importe + (this.Importe * porcentaje /100);
        }
    }
}
