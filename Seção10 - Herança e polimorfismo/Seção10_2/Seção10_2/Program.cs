using Seção10_2.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex,", 0.10);
            BussinesAccount bacc = new BussinesAccount(1102, "Maria", 1000.00, 500000.00);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1001, "Pedro,", 300, 100);
            Account acc3 = new SavingsAccount(1004, "Ana", 500, 0.01);

            //DOWNCASTING

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.0);
            //da errado - acc2.Loan(100.00) - pois acc2 é do tipo account, tem que fazer o downcasting
            //BussinesAccount acc5 = (BussinesAccount)acc3;
            if (acc3 is BussinesAccount)
            {
                BussinesAccount acc5 = (BussinesAccount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}