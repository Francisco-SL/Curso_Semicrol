using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class HistorialMedico
    {
        public HistorialMedico(int numeroHistorial, DateTime fecha)
        {
            NumeroHistorial = numeroHistorial;
            Fecha = fecha;
        }

        public int NumeroHistorial { get; set; }
        public DateTime Fecha { get; set; }
    }
}
