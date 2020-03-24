using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Products.Requests;
using Optivem.Northwind.Core.Application.Products.Responses;
using Optivem.Northwind.Core.Domain.Products.Entities;
using Optivem.Northwind.Core.Domain.Products.Repositories;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;

namespace Optivem.Northwind.Core.Application.Products.UseCases
{
    public class ListProductsUseCase : ListAggregatesUseCase<IProductRepository, ListProductsRequest, ListProductsResponse, ListProductsRecordResponse, Product, ProductIdentity, int>
    {
        public ListProductsUseCase(IProductRepository repository, ICollectionResponseMapper<Product, ListProductsResponse> responseMapper)
            : base(repository, responseMapper)
        {
        }
    }
}
