using AutoMapper;
using Erimont.Core.Domain.Customers;
using System;

namespace Erimont.Infrastructure.Mapping.Customers
{
    public class CustomerIdentityProfile : Profile
    {
        public CustomerIdentityProfile()
        {
            CreateMap<CustomerIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}