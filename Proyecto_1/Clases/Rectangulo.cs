using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Rectangulo
    {
        private double _lado1;
        private double _lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this._lado1 = lado1;
            this._lado2 = lado2;
        }

        public double Lado1
        {
            get
            {
                return _lado1;
            }
            set
            {
                _lado1 = value;
            }
        }

        public double Lado2
        {
            get
            {
                return _lado2;
            }
            set
            {
                _lado2 = value;
            }
        }

        public double Area()
        {
            return this.Lado1*this.Lado2;
        }

        public double Perimetro()
        {
            return this.Lado1 * 2 + this.Lado2 * 2;
        }
    }
}
