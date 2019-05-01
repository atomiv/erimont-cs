﻿using Optivem.Northwind.Core.Application.Dto;
using Optivem.Framework.Core.Application.Services;

namespace Optivem.Northwind.Core.Application.Services
{
    public interface IOrderTaxStatusService : ICrudService<OrderTaxStatusRequest, OrderTaxStatusResponse, int>
    {
    }
}