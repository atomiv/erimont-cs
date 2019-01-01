using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Application.Mapping
{
    public class SupplierRequestMapping : BaseMapping<Supplier, SupplierRequest>
    {
        public SupplierRequestMapping()
        {
            dtoEntityMapping.ForMember(e => e.Products, opt => opt.Ignore());
        }
    }
}
