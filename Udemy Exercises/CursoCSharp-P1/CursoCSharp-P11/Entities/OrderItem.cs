using System.Globalization;

namespace CursoCSharp_P11.Entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}
