using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
	public class PurchaseOrderStatusResponseMapping : BaseMapping<PurchaseOrderStatus, PurchaseOrderStatusResponse>
	{
		public PurchaseOrderStatusResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
