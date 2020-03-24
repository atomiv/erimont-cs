using AutoMapper;
using Optivem.Framework.Infrastructure.AutoMapper;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;

namespace Optivem.Northwind.Infrastructure.AutoMapper.Suppliers
{
    public class CreateSupplierResponseProfile : ResponseProfile<Supplier, CreateSupplierResponse>
    {
        protected override void Extend(IMappingExpression<Supplier, CreateSupplierResponse> map)
        {
            // TODO: Should we require strict mappings? or at least some warning that a field was not mapped
            // and that no field in source was found with the identical name and type

            // TODO: VC: Separate mappings just for ids
            map.ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.Id.Id))
                .ForMember(dest => dest.Company, opt => opt.MapFrom(e => e.Company))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(e => e.ContactPerson.LastName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(e => e.ContactPerson.FirstName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(e => e.ContactDetails.EmailAddress))
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(e => e.ContactPerson.JobTitle))
                .ForMember(dest => dest.BusinessPhone, opt => opt.MapFrom(e => e.ContactDetails.BusinessPhone))
                .ForMember(dest => dest.HomePhone, opt => opt.MapFrom(e => e.ContactDetails.HomePhone))
                .ForMember(dest => dest.MobilePhone, opt => opt.MapFrom(e => e.ContactDetails.MobilePhone))
                .ForMember(dest => dest.FaxNumber, opt => opt.MapFrom(e => e.ContactDetails.FaxNumber))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(e => e.Address.Address))
                .ForMember(dest => dest.City, opt => opt.MapFrom(e => e.Address.City))
                .ForMember(dest => dest.StateProvince, opt => opt.MapFrom(e => e.Address.StateProvince))
                .ForMember(dest => dest.ZipPostalCode, opt => opt.MapFrom(e => e.Address.ZipPostalCode))
                .ForMember(dest => dest.CountryRegion, opt => opt.MapFrom(e => e.Address.CountryRegion))
                .ForMember(dest => dest.WebPage, opt => opt.MapFrom(e => e.ContactDetails.WebPage))
                .ForMember(dest => dest.Notes, opt => opt.MapFrom(e => e.Notes));
        }
    }
}
