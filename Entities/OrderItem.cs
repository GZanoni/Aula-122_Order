using System.Collections.Generic;

namespace Orders_122.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product prod)
        {
            Quantity = quantity;
            Price = price;
            Product = prod;
        }


        public double SubTotal()
        {
            return Quantity * Price;

        }


       public override string ToString() //faltou no meu codigo
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }

    }
}
