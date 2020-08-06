using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1
{
    class FactoriaAnimal
    {
        public static Animal GetAnimal(string tipo, int peso, string color)
        {
            if (tipo.Equals("Gato"))
            {
                return new Gato(color, peso);
            }
            else if (tipo.Equals("Perro"))
            {
                return new Perro(color, peso);
            }
            else
            {
                return null;
            }
        }
       
    }
}
