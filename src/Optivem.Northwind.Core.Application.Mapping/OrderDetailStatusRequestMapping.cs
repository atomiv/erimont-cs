using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class OrderDetailStatusRequestMapping : BaseMapping<OrderDetailStatus, OrderDetailStatusRequest>
	{
		public OrderDetailStatusRequestMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
