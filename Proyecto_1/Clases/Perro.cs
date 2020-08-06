using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class Perro : Animal
    {
        public string Collar { get; set; }


        public Perro(string color, int peso) : base(color, peso)
        {
        }

        public override void Vacunar()
        {
            Console.WriteLine("Vacunamos al perro con 2 inyecciones");
            EstaVacunado = true;
        }

       
    }
}
