using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Interface
{
    class Program23
    {
        static void Main(string[] args)
        {
            IConducible miMoto = new Moto();
            miMoto.Arracar();
            IConducibleConectable miPatinete = new Patinete();
            IConectable miPatinete2 = new Patinete();
            miPatinete2.Conectar();
            miPatinete2.Desconectar();
            miPatinete.Avanzar();
            Mover(miPatinete);
            miPatinete.Conectar();
            Conectar(miPatinete);
            Console.ReadLine();
        }

        public static void Mover(IConducible c)
        {
            c.Arracar();
            c.Avanzar();
            c.Girar();
            c.Parar();
        }

        public static void Conectar(IConectable i)
        {
            i.Conectar();
            i.Desconectar();
        }
    }
}
