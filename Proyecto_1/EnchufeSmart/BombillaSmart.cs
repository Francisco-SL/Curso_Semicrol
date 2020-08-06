using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EnchufeSmart
{
    class BombillaSmart : Bombilla, IEncendibleVoz
    {
        public BombillaSmart(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public void ApagarVoz()
        {
            Console.WriteLine("La {0} se apaga por voz", GetType().Name);
        }

        public void EncenderVoz()
        {
            Console.WriteLine("La {0} se enciende por voz", GetType().Name);
        }

        public override bool Equals(object obj)
        {
            var smart = obj as BombillaSmart;
            return smart != null &&
                   Id == smart.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
