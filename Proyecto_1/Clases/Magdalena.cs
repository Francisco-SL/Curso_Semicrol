using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Magdalena
    {
        private string _color;
        private int _peso;
        private int _precio;

        public String Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!value.Equals("Azul"))
                {
                    _color = value;
                }
            }
        }

        public int Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                if (_peso < 4)
                {
                    _peso = value;
                }
                else
                {
                    _peso = 0;
                }
            }
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (_precio < 4)
                {
                    _precio = value;
                }
                else
                {
                    _precio = 0;
                }
            }
        }
    }
}
