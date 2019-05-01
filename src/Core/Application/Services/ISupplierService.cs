﻿using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Framework.Core.Application.Services;

namespace Optivem.Northwind.Core.Application.Services
{
    public interface ISupplierService : ICrudService<SupplierRequest, SupplierResponse, int>
    {
    }
}