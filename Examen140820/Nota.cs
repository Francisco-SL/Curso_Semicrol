using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen140820
{
    class Nota
    {
        public double Valor { get; set; }

        public Nota(double valor)
        {
            Valor = valor;
        }

        public Nota EsMayor(Nota otra)
        {
            return new Nota(Nota.EsMayor(Valor, otra.Valor));
        }

        public Nota EsMenor(Nota otra)
        {
            return new Nota(Nota.EsMenor(Valor, otra.Valor));
        }

        public static double EsMayor(double valor1, double valor2)
        {
            return valor1 > valor2 ? valor1 : valor2;
        }       

        public static double EsMenor(double valor1, double valor2)
        {
            return valor1 < valor2 ? valor1 : valor2;
        }

    }
}
