﻿using AutoMapper;
using Optivem.Framework.Infrastructure.AutoMapper;
using Optivem.Northwind.Core.Application.Customers.Responses;
using Optivem.Northwind.Core.Domain.Customers.Entities;

namespace Optivem.Northwind.Infrastructure.AutoMapper.Customers
{
    public class UpdateCustomerResponseProfile : ResponseProfile<Customer, UpdateCustomerResponse>
    {
        protected override void Extend(IMappingExpression<Customer, UpdateCustomerResponse> map)
        {
            // TODO: VC: Separate mappings just for ids
            map.ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.Id.Id));
        }
    }
}
