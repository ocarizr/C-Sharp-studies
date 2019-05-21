using CursoCSharp_P14.Entities.Enums;

namespace CursoCSharp_P14.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
    }
}
