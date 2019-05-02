using System;

namespace Optivem.Northwind.Core.Application.UseCases
{
    public class InventoryTransactionRequest
    {
        public int Id { get; set; }
        public byte TransactionTypeId { get; set; }
        public DateTime TransactionCreatedDate { get; set; }
        public DateTime TransactionModifiedDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int PurchaseOrderId { get; set; }
        public int CustomerOrderId { get; set; }
        public string Comments { get; set; }
    }
}