using AutoMapper;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    // TODO: VC: Check why not working
    public class SupplierRequestMapping : AutoMapperRequestProfile<SupplierRequest, Supplier>
    {
        public SupplierRequestMapping()
        {
            map.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
        }
    }
}