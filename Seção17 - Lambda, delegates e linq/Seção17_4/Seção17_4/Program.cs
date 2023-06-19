using Seção17_4.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}