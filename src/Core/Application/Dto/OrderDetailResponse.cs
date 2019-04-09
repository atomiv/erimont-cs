using System;

namespace Optivem.Northwind.Core.Application.Dto
{
	public class OrderDetailResponse
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public decimal Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public double Discount { get; set; }
		public byte StatusId { get; set; }
		public DateTime DateAllocated { get; set; }
		public int PurchaseOrderId { get; set; }
		public int InventoryId { get; set; }
	}
}
