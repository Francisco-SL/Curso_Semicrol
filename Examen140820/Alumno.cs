using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen140820
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
    
        public Nota NotaMayor()
        {
            Nota notaMayor = new Nota(Notas[0].Valor);
            foreach (Nota n in Notas)
            {
                notaMayor = n.EsMayor(notaMayor);
            }
            return notaMayor;
        }

        public Nota NotaMenor()
        {
            Nota notaMenor = new Nota(Notas[0].Valor);
            foreach (Nota n in Notas)
            {
                notaMenor = n.EsMenor(notaMenor);
            }
            return notaMenor;
        }

        public void InformacionNotas()
        {
            Console.WriteLine("La nota mayor de {0} es de {1} puntos", Nombre, NotaMayor().Valor);
            Console.WriteLine("La nota menor de {0} es de {1} puntos", Nombre, NotaMenor().Valor);
        }


    }
}
