using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    public class SupplierRequestMapping : BaseMapping<Supplier, SupplierRequest>
    {
        public SupplierRequestMapping()
        {
            // dtoEntityMapping.ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
        }
    }
}
