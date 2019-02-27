using System;
using System.Globalization;
using CursoCSharp_P11.Entities;
using CursoCSharp_P11.Entities.Enums;

namespace CursoCSharp_P11
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientName;
            string clientEmail;
            DateTime clientBirthDate;

            OrderStatus orderStatus;
            int itemCount;
            string productName;
            double productPrice;
            int productQuantity;

            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            clientName = Console.ReadLine();
            Console.Write("Email: ");
            clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);

            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine();

            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(orderStatus, client);

            Console.Write("How many items to this order? ");
            itemCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                productName = Console.ReadLine();
                Console.Write("Product price: $");
                productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}
