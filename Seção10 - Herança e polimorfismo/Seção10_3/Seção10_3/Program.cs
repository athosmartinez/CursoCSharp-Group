using Seção10_3.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex,", 500);
            Account acc2 = new SavingsAccount(1001, "Alex,", 500, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}