using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Mapping
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
