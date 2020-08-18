using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
 abstract   class Fichero
       
    {
        public Fichero(string nombre, int tamaño)
        {
            Nombre = nombre;
            Tamaño = tamaño;
        }

        public string Nombre { get; set; }
        public int Tamaño { get; set; }
    }
}
