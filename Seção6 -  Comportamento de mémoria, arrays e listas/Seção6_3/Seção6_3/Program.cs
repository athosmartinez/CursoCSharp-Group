using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de elementos do Array: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite as alturas: ");

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("A média é: " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}