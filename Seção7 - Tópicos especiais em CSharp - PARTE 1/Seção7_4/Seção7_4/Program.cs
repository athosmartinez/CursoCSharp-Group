using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 59, 04);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 59, 04, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine("------------------------------------------");
            DateTime data1 = DateTime.Parse("2000-08-15");
            Console.WriteLine(data1);
            DateTime Hora1 = DateTime.Parse("2000-08-15, 13:05:58");
            Console.WriteLine(Hora1);
            DateTime data2 = DateTime.Parse("15/08/2000");
            Console.WriteLine(data2);
            DateTime Hora2 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(Hora2);
            Console.WriteLine("------------------------------------------");
            DateTime DateExact1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(DateExact1);
            DateTime DateExact2 = DateTime.ParseExact("15/08/2000 13:04:20", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(DateExact2);

        }
    }
}