using System;
using Orders_122.Entities;
using Orders_122.Entities.Enums;

namespace Orders_122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus sts = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, sts, client);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter item #{i} data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product prod = new Product(prodName, price);
                
                Console.Write("Quantity: ");
                int N = int.Parse(Console.ReadLine());
                
                OrderItem item = new OrderItem(N, price, prod);

                order.addItem(item);
                                               
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}
