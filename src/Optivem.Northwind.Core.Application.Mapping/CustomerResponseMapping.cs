using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
	public class CustomerResponseMapping : BaseMapping<Customer, CustomerResponse>
	{
		public CustomerResponseMapping()
		{
			// TODO: VC: Check if needed
			// dtoEntityMapping.ForMember(e => e.Order, opt => opt.Ignore());
		}
	}
}
