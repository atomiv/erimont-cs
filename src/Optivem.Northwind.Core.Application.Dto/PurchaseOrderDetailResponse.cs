using System;

namespace Optivem.Northwind.Core.Application.Dto
{
	public class PurchaseOrderDetailResponse
	{
		public int Id { get; set; }
		public int PurchaseOrderId { get; set; }
		public int ProductId { get; set; }
		public decimal Quantity { get; set; }
		public decimal UnitCost { get; set; }
		public DateTime DateReceived { get; set; }
		public bool PostedToInventory { get; set; }
		public int InventoryId { get; set; }
	}
}
