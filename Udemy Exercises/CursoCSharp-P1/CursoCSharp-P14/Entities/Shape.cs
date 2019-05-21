using CursoCSharp_P14.Entities.Enums;

namespace CursoCSharp_P14.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; private set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();    
    }
}
