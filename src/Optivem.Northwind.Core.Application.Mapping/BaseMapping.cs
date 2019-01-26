using AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping
{
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
