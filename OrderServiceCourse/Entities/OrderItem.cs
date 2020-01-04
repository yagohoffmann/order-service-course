﻿using System.Globalization;
namespace OrderServiceCourse.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; } = new Product();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return product.Name + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity
                + ", Subtotal: $" + SubTotal();
        }
    }
}
