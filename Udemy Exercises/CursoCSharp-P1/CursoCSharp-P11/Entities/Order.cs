using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using CursoCSharp_P11.Entities.Enums;

namespace CursoCSharp_P11.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Client Client;

        public Order(OrderStatus orderStatus, Client client)
        {
            Moment = DateTime.Now;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("OrderStatus: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            for(int i = 0; i < Items.Count; i++)
            {
                sb.AppendLine(Items[i].ToString());
            }

            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
