using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class InventoryTransactionTypeRequestMapping : BaseMapping<InventoryTransactionType, InventoryTransactionTypeRequest>
	{
		public InventoryTransactionTypeRequestMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
