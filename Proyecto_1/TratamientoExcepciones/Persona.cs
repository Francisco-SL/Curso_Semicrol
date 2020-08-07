using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.TratamientoExcepciones
{
    class Persona
    {
        public string Nombre { get; set; }
        private int _edad;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            _edad = edad;
        }

        public Persona()
        {
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                if(value < 0 || value > 120)
                {
                    _edad = 0;
                    throw new Exception("La edad no es valida, la edad recogera el valor por defecto");
                }
                else
                {
                    _edad = value;
                }
            }
        }

        
    }
}
