using AutoMapper;
using Erimont.Core.Application.Products.Commands;
using Erimont.Core.Domain.Products;

namespace Erimont.Infrastructure.Mapping.Products
{
    public class CreateProductCommandResponseProfile : Profile
    {
        public CreateProductCommandResponseProfile()
        {
            CreateMap<Product, CreateProductCommandResponse>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(e => e.ProductCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(e => e.ProductName))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(e => e.ListPrice));
        }
    }
}
