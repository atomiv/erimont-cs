using System;
using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class Product
    {
        public Product()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
            OrderDetail = new HashSet<OrderDetail>();
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }

        public int Id { get; set; }
        public string SupplierId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public short ReorderLevel { get; set; }
        public int TargetLevel { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public short MinimumReorderQuantity { get; set; }
        public string Category { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransaction { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
    }
}
