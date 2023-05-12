using Seção10_6.Entities;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            accounts.Add(new BussinesAccount(1002, "Maria", 500, 2000));
            accounts.Add(new SavingsAccount(1003, "Pedro", 500, 0.01));
            accounts.Add(new BussinesAccount(1004, "Andre", 500, 3000));
            double sum = 0;
            foreach (var account in accounts)
            {
                sum += account.Balance;
            }


            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            foreach (var account in accounts)
            {
                account.WithDraw(10.0);

            }

            foreach (var account in accounts)
            {
                Console.WriteLine("Updated balance for acount: " + account.Number + ": " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}