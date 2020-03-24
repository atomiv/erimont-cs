using AutoMapper;
using Erimont.Core.Application.Customers.Commands;
using Erimont.Core.Domain.Customers;

namespace Erimont.Infrastructure.Mapping.Customers
{
    public class EditCustomerCommandResponseProfile : Profile
    {
        public EditCustomerCommandResponseProfile()
        {
            CreateMap<Customer, EditCustomerCommandResponse>();
        }
    }
}
