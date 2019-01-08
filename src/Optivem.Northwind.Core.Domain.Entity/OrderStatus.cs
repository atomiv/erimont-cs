using System;
using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Order = new HashSet<Order>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
