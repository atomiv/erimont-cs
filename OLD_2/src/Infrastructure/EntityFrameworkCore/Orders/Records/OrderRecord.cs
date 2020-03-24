﻿using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Customers.Records;
using System.Collections.Generic;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Orders.Records
{
    public class OrderRecord
    {
        public OrderRecord()
        {
            OrderDetail = new HashSet<OrderDetailRecord>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public byte StatusId { get; set; }

        public virtual CustomerRecord Customer { get; set; }
        public virtual OrderStatusRecord Status { get; set; }
        public virtual ICollection<OrderDetailRecord> OrderDetail { get; set; }
    }
}