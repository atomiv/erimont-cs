using AutoMapper;
using Erimont.Core.Domain.Products;
using System;

namespace Erimont.Infrastructure.Mapping.Products
{
    public class ProductIdentityProfile : Profile
    {
        public ProductIdentityProfile()
        {
            CreateMap<ProductIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}