using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class InventoryTransactionTypeResponseMapping : BaseMapping<InventoryTransactionType, InventoryTransactionTypeResponse>
	{
		public InventoryTransactionTypeResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
