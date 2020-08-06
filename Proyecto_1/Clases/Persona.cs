using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Persona
    {
        private string _nombre;
        private string _apellidos;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int Edad { get => _edad; set => _edad = value; }

        public int TiempoParaJubilarse()
        {
            return 70 - this.Edad;
        }

        public override string ToString()
        {
            return Nombre+", "+Apellidos+", "+Edad;
        }
    }
}
