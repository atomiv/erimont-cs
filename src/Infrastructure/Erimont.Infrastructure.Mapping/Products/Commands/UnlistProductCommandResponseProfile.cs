using AutoMapper;
using Erimont.Core.Application.Products.Commands;
using Erimont.Core.Domain.Products;

namespace Erimont.Infrastructure.Mapping.Products
{
    public class UnlistProductCommandResponseProfile : Profile
    {
        public UnlistProductCommandResponseProfile()
        {
            CreateMap<Product, UnlistProductCommandResponse>();
        }
    }
}
