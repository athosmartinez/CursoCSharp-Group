using Seção17_3.Services;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                double a = 10;
                double b = 12;
                BinaryNumericOperation op = CalculationService.ShowSum;
                op += CalculationService.ShowMax;
                op(a, b);
            }
        }
    }
}