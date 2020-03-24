using AutoMapper;
using Erimont.Core.Application.Products.Commands;
using Erimont.Core.Domain.Products;

namespace Erimont.Infrastructure.Mapping.Products
{
    public class RelistProductCommandResponseProfile : Profile
    {
        public RelistProductCommandResponseProfile()
        {
            CreateMap<Product, RelistProductCommandResponse>();
        }
    }
}
