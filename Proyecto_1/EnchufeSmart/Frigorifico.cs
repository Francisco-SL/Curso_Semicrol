using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EnchufeSmart
{
    class Frigorifico : IEncendible, IComparable<Frigorifico>
    {
        public Frigorifico(int potencia)
        {
            Potencia = potencia;
        }

        public int Potencia { get; set; }


        public void Apagar()
        {
            Console.WriteLine("El {0} se apaga", GetType().Name);
        }

        public int CompareTo(Frigorifico other)
        {
            if (other.Potencia < Potencia)
            {
                return -1;
            }
            else if (other.Potencia == Potencia)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void Encender()
        {
            Console.WriteLine("El {0} se enciende", GetType().Name);
        }
    }
}
