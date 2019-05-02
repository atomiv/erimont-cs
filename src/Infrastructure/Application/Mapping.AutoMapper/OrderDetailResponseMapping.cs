﻿using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    public class OrderDetailResponseMapping : AutoMapperResponseProfile<OrderDetail, OrderDetailResponse>
    {
    }
}