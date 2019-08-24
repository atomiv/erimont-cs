using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class ProductService : CrudService<IMappingService, INorthwindUnitOfWork, IProductRepository, ProductRequest, ProductResponse, Product, int>, IProductService
    {
        public ProductService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.ProductRepository)
        {
        }
    }
}