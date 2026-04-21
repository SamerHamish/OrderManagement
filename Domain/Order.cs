using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public required string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
