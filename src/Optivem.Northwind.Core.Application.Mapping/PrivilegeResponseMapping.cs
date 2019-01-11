using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Application.Mapping
{
	public class PrivilegeResponseMapping : BaseMapping<Privilege, PrivilegeResponse>
	{
		public PrivilegeResponseMapping()
		{
			// dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
