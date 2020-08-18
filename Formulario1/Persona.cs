using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario1
{
    class Persona
    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
