using System;
using System.Collections.Generic;
using System.Text;
using OrderServiceCourse.Entities.Enums;

namespace OrderServiceCourse.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Cliente cliente { get; set; } = new Cliente();
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
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
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy hh:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {cliente.Name} ({cliente.BirthDate.ToString("dd/MM/yyyy")}) - {cliente.Email}");
            foreach (OrderItem item in Items) sb.AppendLine(item.ToString());
            sb.AppendLine($"Total price: ${Total()}");
            return sb.ToString();
        }
    }
}
