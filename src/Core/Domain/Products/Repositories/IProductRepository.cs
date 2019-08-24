using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Products.Entities;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Products.Repositories
{
    public interface IProductRepository : ICrudRepository<Product, ProductIdentity>, IPageAggregatesRepository<Product, ProductIdentity>
    {
    }
}