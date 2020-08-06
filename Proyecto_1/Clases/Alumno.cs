using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Alumno
    {
        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

       
        public string Nombre { get; set; }
        public List<Nota> Notas
        {
            get
            {
                return _Notas;
            }

            set
            {
                _Notas = value;
            }
        }
        private List<Nota> _Notas = new List<Nota>();

        public void AddNota(Nota not)
        {
            Notas.Add(not);
        }

        public Nota NotaMedia()
        {
            double acum = 0;
            foreach (Nota n in Notas)
            {
                acum += n.Valor;
            }
            return new Nota(acum / Notas.Count);
        }

        public Nota NotaMayor()
        {
            Nota notaMayor = new Nota(0);
            foreach (Nota n in Notas)
            {
                notaMayor = n.EsMayor(notaMayor);
            }
            return notaMayor;
        }
    }
}
