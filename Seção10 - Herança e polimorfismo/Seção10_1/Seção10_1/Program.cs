using Seção10_1.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(8100, "Bob", 100.00, 600);

            Console.WriteLine(account.Balance);

            
        }
    }
}