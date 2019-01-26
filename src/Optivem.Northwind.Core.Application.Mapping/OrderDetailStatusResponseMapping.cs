using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class OrderDetailStatusResponseMapping : BaseMapping<OrderDetailStatus, OrderDetailStatusResponse>
	{
		public OrderDetailStatusResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
