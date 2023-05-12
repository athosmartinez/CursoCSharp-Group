using Seção10_7.Entities;
using Seção10_7.Entities.Enums;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int NumberShapes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char WhatShape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (WhatShape == 'r' || WhatShape == 'R')
                {

                    Console.Write("Width: ");
                    double widht = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}