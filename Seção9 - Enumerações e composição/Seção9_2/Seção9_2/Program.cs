using Seção9_2.Entities;
using Seção9_2.Entities.Enums;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string DeptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(DeptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contratcs to this worker? ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value per Hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}