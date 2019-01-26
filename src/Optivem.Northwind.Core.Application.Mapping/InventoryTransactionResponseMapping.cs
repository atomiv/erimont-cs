using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class InventoryTransactionResponseMapping : BaseMapping<InventoryTransaction, InventoryTransactionResponse>
	{
		public InventoryTransactionResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
