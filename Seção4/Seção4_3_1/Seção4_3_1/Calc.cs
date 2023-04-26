using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção4_3_1
{
    internal class Calc
    {
        public double Pi = 3.14;
        public double Circunferencia(double raio)
        {
            return (double)2 * Pi * raio;
        }
        public double Volume(double raio)
        {
            return (double)4 / 3 * Pi * Math.Pow(raio, 3);
        }
    }
}
