using Seção17_2.Services;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                double a = 10;
                double b = 12;
                // BinaryNumericOperation op = CalculationService.Sum;
                BinaryNumericOperation op = new BinaryNumericOperation(CalculationServices.Sum);
                // double result = op(a, b);
                double result = op.Invoke(a, b);
                Console.WriteLine(result);
            }
    }
}