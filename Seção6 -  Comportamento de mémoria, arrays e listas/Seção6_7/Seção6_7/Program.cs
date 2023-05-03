using System;

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


        }
    }
}