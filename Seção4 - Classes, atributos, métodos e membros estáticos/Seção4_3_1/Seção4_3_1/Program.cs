using Seção4_3_1;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calculadora = new Calc();
            Console.WriteLine("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Circ = calculadora.Circunferencia(Raio);
            double Volum = calculadora.Volume(Raio);

            Console.WriteLine("Circunferencia: " + Circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}