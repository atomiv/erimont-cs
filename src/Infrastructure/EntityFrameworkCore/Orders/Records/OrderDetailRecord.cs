﻿using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Products.Records;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Orders.Records
{
    public class OrderDetailRecord
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual OrderRecord Order { get; set; }
        public virtual ProductRecord Product { get; set; }
        public virtual OrderDetailStatusRecord Status { get; set; }
    }
}