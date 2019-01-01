using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Mapping
{
    public class SupplierResponseMapping : BaseMapping<Supplier, SupplierResponse>
    {
        public SupplierResponseMapping()
        {
            dtoEntityMapping.ForMember(e => e.Products, opt => opt.Ignore());
        }
    }
}
