using AutoMapper;
using Erimont.Core.Application.Customers.Commands;
using Erimont.Core.Domain.Customers;

namespace Erimont.Infrastructure.Mapping.Customers
{
    public class DeleteCustomerCommandResponseProfile : Profile
    {
        public DeleteCustomerCommandResponseProfile()
        {
            CreateMap<Customer, DeleteCustomerCommandResponse>();
        }
    }
}