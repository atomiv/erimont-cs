using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;
using Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier;
using Optivem.Northwind.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier
{
    // TODO: VC: Perhaps these mappers should be in the application layer?

    public class CreateSupplierRequestMapping : AutoMapperRequestProfile<CreateSupplierRequest, Supplier>
    {
        public CreateSupplierRequestMapping()
        {
            map.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
        }
    }
}
