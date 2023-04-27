using Seção6_1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo struct
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}