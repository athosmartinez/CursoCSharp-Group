using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Circ = Circunferencia(Raio);
            double Volum = Volume(Raio);

            Console.WriteLine("Circunferencia: " + Circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double raio)
        {
            return (double)2 * Pi * raio;
        }
        static double Volume(double raio)
        {
            return (double)4 / 3 * Pi * Math.Pow(raio, 3);
        }


    }
}