using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());


                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!" + e.Message);
            }
        }
    }
}