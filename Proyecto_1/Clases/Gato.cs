using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class Gato : Animal
    {
        public string Cascabel { get; set; }

        public Gato(string color, int peso) : base(color, peso)
        {
        }

        public override void Vacunar()
        {
            Console.WriteLine("Vacunamos al gato con 1 inyeccion");
            EstaVacunado = true;
        }
    }
}
