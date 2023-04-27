using Seção6_5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.SumP(2, 4);
            int s2 = Calculator.SumP(4, 5, 10, 130, 4);
            int s3 = Calculator.SumP(4, 5, 5, 5, 4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            //usando ref - valor precisa ser iniciado
            int a = 10;
            Calculator.TripleR(ref a);
            Console.WriteLine(a);
            //usando out - valor não precisa ser iniciado
            int b = 10;
            int triple;
            Calculator.TripleO(b, out triple);
            Console.WriteLine(triple);
        }
    }
}