using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;
using Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier;
using Optivem.Northwind.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier
{
    public class CreateSupplierResponseMapping : AutoMapperResponseProfile<Supplier, CreateSupplierResponse>
    {
    }
}
