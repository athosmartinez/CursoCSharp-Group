using Seção6_4;
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome: ");
                string name = Console.ReadLine();
                Console.Write("Digite o valor: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avr = sum / n;
            Console.WriteLine("A média é: " + avr.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}