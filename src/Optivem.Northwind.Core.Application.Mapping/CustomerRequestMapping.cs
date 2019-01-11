using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Application.Mapping
{
	public class CustomerRequestMapping : BaseMapping<Customer, CustomerRequest>
	{
		public CustomerRequestMapping()
		{
			// TODO: Check if needed
			// dtoEntityMapping.ForMember(e => e.Order, opt => opt.Ignore());
		}
	}
}
