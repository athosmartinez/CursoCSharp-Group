using Seção4_3_2;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Circ = Calc.Circunferencia(Raio);
            double Volum = Calc.Volume(Raio);

            Console.WriteLine("Circunferencia: " + Circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}