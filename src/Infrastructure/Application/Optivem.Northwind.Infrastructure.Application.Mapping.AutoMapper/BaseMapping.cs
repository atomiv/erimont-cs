using AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    // TODO: VC: Remove from here, this will be in platform

    public class BaseMapping<TEntity, TDto> : Profile
    {
        protected IMappingExpression<TEntity, TDto> entityDtoMapping;

        protected IMappingExpression<TDto, TEntity> dtoEntityMapping;

        public BaseMapping()
        {
            entityDtoMapping = CreateMap<TEntity, TDto>();
            dtoEntityMapping = CreateMap<TDto, TEntity>();
        }
    }
}
