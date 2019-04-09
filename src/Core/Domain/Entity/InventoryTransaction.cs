using System;
using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class InventoryTransaction
    {
        public InventoryTransaction()
        {
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }

        public int Id { get; set; }
        public byte TransactionTypeId { get; set; }
        public DateTime TransactionCreatedDate { get; set; }
        public DateTime TransactionModifiedDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int PurchaseOrderId { get; set; }
        public int CustomerOrderId { get; set; }
        public string Comments { get; set; }

        public virtual Order CustomerOrder { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual InventoryTransactionType TransactionType { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
    }
}