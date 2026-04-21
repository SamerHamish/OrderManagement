using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public required string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
