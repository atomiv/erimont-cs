using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Products.Requests;
using Optivem.Northwind.Core.Application.Products.Responses;
using Optivem.Northwind.Core.Domain.Products.Entities;
using Optivem.Northwind.Core.Domain.Products.Repositories;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;

namespace Optivem.Northwind.Core.Application.Products.UseCases
{
    public class BrowseProductsUseCase : BrowseAggregatesUseCase<IProductRepository, BrowseProductsRequest, BrowseProductsResponse, BrowseProductsRecordResponse, Product, ProductIdentity, int>
    {
        public BrowseProductsUseCase(IProductRepository repository, ICollectionResponseMapper<Product, BrowseProductsResponse> responseMapper)
            : base(repository, responseMapper)
        {
        }
    }
}
