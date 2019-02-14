using System;
using CursoCSharp_P8.Entities;
using CursoCSharp_P8.Entities.Enums;

namespace CursoCSharp_P8 // Enum Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = order.Status.ToString();

            Console.WriteLine(txt);

            txt = "Delivered";

            order.Status = Enum.Parse<OrderStatus>(txt);

            Console.WriteLine(order.Status);
        }
    }
}
