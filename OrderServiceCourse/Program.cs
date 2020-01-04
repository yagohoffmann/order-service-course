using System;
using System.Globalization;
using OrderServiceCourse.Entities;
using OrderServiceCourse.Entities.Enums;

namespace OrderServiceCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order();
            Console.WriteLine("Enter client data: ");            
            Console.Write("Name: ");
            pedido.cliente.Name = Console.ReadLine();
            Console.Write("Email: ");
            pedido.cliente.Email = Console.ReadLine();
            Console.Write("Birth date: ");
            pedido.cliente.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            pedido.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quant = int.Parse(Console.ReadLine());
            for(int i = 0; i<quant; i++)
            {
                Console.WriteLine("");
                OrderItem item = new OrderItem();
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                item.product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                item.product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                item.Price = item.product.Price;
                Console.Write("Quantity: ");
                item.Quantity = int.Parse(Console.ReadLine());
                pedido.AddItem(item);
            }
            pedido.Moment = DateTime.Now;
            Console.WriteLine("");
            Console.WriteLine(pedido);
        }
    }
}
