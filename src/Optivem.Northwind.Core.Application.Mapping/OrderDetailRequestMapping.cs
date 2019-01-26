using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class OrderDetailRequestMapping : BaseMapping<OrderDetail, OrderDetailRequest>
	{
		public OrderDetailRequestMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
