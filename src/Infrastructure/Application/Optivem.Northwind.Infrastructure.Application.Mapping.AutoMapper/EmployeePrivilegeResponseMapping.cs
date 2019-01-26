using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
	public class EmployeePrivilegeResponseMapping : BaseMapping<EmployeePrivilege, EmployeePrivilegeResponse>
	{
		public EmployeePrivilegeResponseMapping()
		{
			// // dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
		}
	}
}
