using CursoCSharp_P14.Entities.Enums;
using System;

namespace CursoCSharp_P14.Entities
{
    class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(Radius, 2);
    }
}
