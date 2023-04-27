using System;

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
                double altura = double.Parse(Console.ReadLine());
                vect[i] = altura;
            }

        }
    }
}