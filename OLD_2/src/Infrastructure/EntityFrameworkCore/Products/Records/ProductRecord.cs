using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Orders.Records;
using System.Collections.Generic;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Products.Records
{
    public class ProductRecord : IIdentity<int>
    {
        public ProductRecord()
        {
            OrderDetail = new HashSet<OrderDetailRecord>();
        }

        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ListPrice { get; set; }

        public virtual ICollection<OrderDetailRecord> OrderDetail { get; set; }
    }
}