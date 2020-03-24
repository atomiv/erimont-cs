using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Products.Requests;
using Optivem.Northwind.Core.Application.Products.Responses;
using Optivem.Northwind.Core.Domain.Products.Entities;
using Optivem.Northwind.Core.Domain.Products.Repositories;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;

namespace Optivem.Northwind.Core.Application.Products.UseCases
{
    public class UnlistProductUseCase : UpdateAggregateUseCase<IProductRepository, UnlistProductRequest, UnlistProductResponse, Product, ProductIdentity, int>
    {
        public UnlistProductUseCase(IUnitOfWork unitOfWork, IResponseMapper responseMapper) : base(unitOfWork, responseMapper)
        {
        }

        protected override ProductIdentity GetIdentity(int id)
        {
            throw new System.NotImplementedException();
        }

        protected override void Update(Product aggregateRoot, UnlistProductRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
