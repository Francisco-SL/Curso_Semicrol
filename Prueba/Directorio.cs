using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Directorio:Fichero
    {
        public List<Fichero> Ficheros { get; set; }
        public Directorio(string nom, int tam) : base(nom, tam)
        {
            Ficheros = new List<Fichero>();
        }

        public void AddFichero(Fichero f)
        {
            Ficheros.Add(f);
        }
    }
}
