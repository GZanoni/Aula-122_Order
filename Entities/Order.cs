using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;
using Orders_122.Entities.Enums;


namespace Orders_122.Entities
{
    class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Item { get; set; } = new List<OrderItem>();


        public Order()
        {
        }

       
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }


        public void addItem(OrderItem newItem)
        {

            Item.Add(newItem);
        }


        public void removeItem(OrderItem newItem)
        {
            Item.Remove(newItem);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Item)
            {
                sum += item.SubTotal();

            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());

            }

            sb.AppendLine("Total price: " + Total());
            return sb.ToString();
        }

    }
}




