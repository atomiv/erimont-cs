using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
	public class CustomerRequestMapping : BaseMapping<Customer, CustomerRequest>
	{
		public CustomerRequestMapping()
		{
			// TODO: VC: Check if needed
			// dtoEntityMapping.ForMember(e => e.Order, opt => opt.Ignore());
		}
	}
}
