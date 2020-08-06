using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Nota
    {
        private double _valor;

        public Nota(double valor)
        {
            this._valor = valor;
        }

        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }

        public string TipoNota()
        {
            if (Valor >= 0 && this.Valor <= 4)
            {
                return "La nota es insuficiente";
            }
            else if (Valor >= 5)
            {
                return "La nota es suficiente";
            }
            else if (Valor >= 6)
            {
                return "La nota es buena";
            }
            else if (Valor >= 7 || Valor <= 8)
            {
                return "La nota es notable";
            }
            else if (Valor >= 9 || Valor <= 10)
            {
                return "La nota es sobresaliente";
            }
            else
            {
                return "No valida";
            }
        }

        public Nota EsMayor(Nota otra)
        {
            return new Nota(Nota.EsMayor(Valor, otra.Valor));
        }

        public static double EsMayor(double valor1, double valor2)
        {
            if (valor1 > valor2)
            {
                return valor1;
            }
            else
            {
                return valor2;
            }
        }

        
    }
}
