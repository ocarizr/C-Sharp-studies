using System;
using System.Collections.Generic;
using System.Globalization;
using CursoCSharp_P14.Entities;
using CursoCSharp_P14.Entities.Enums;

namespace CursoCSharp_P14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>
            {
                new Circle(5.0, Enum.Parse<Color>("Black")),
                new Rectangle(2.0, 10.0, Enum.Parse<Color>("Blue")),
                new Circle(3.0, Enum.Parse<Color>("Pink")),
                new Rectangle(2.5, 4.0, Enum.Parse<Color>("Pink"))
            };

            Console.WriteLine("Areas of the Shapes:");

            Console.WriteLine();
            
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
