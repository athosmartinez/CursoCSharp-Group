using Seção6_5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 4);
            int s2 = Calculator.Sum(4, 5, 10, 130, 4);
            int s3 = Calculator.Sum(4, 5, 5, 5, 4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}