using Seção4_1;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os valores do triangulo X: ");
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite os valores do trianuglo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX < areaY) { Console.WriteLine("A maior area é a do Y com " + areaY.ToString("F4", CultureInfo.InvariantCulture)); }
            else if (areaX > areaY) { Console.WriteLine("A maior era é do X com " + areaX.ToString("F4", CultureInfo.InvariantCulture)); }
            else { Console.WriteLine("São iguais!"); }
        }



    }
}