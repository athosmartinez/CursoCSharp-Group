using System;
using System.Runtime.ExceptionServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] Matriz = new double[2, 3];
            Console.WriteLine(Matriz.Length);
            Console.WriteLine("Quantidade de linhas: " + Matriz.Rank);
            Console.WriteLine("Primeira dimensao: " + Matriz.GetLength(0));
            Console.WriteLine("Sgunda dimensao: " + Matriz.GetLength(1));


            int n = int.Parse(Console.ReadLine());
            double[,] Mat = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    Mat[i, j] = int.Parse(values[j]);
                }

            }



        }
    }
}