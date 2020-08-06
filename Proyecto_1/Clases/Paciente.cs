using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Paciente
    {
        public Paciente(string dNI, string nombre)
        {
            DNI = dNI;
            Nombre = nombre;
        }

        public Paciente(string dNI, string nombre, HistorialMedico historial) : this(dNI, nombre)
        {
            Historial = historial;
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public HistorialMedico Historial { get; set; }
    }
}
