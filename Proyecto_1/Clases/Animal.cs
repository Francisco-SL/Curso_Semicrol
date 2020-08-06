using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    abstract class Animal
    {
        public Animal(string color, int peso)
        {
            Color = color;
            Peso = peso;
        }

        public string Color { get; set; }
        public int Peso { get; set; }
        public bool EstaVacunado { get; set; }

        public abstract void Vacunar();
    }
}
