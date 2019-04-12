using AutoMapper;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Platform.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    // TODO: VC: Check why not working
    // public class SupplierRequestMapping : AutoMapperRequestProfile<Supplier, SupplierRequest>
    public class SupplierRequestMapping : Profile
    {
        public SupplierRequestMapping()
        {
            this.CreateMap<SupplierRequest, Supplier>()
                .ForMember(e => e.PurchaseOrder, opt => opt.Ignore());
        }
    }
}