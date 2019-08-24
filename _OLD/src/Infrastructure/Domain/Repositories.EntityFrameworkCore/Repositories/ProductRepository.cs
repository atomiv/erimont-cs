using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class ProductRepository : EntityFrameworkRepository<NorthwindContext, Product, int>, IProductRepository
    {
        public ProductRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}