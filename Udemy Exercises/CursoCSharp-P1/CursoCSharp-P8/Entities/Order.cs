using System;
using CursoCSharp_P8.Entities.Enums;

namespace CursoCSharp_P8.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", " 
                + Moment 
                + ", " 
                + Status;
        }
    }
}
