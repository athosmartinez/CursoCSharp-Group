using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            if (x.HasValue)
            {

                Console.WriteLine(x.HasValue);
            }
            else
            {
                Console.WriteLine("X is null");

            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");

            }


            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}