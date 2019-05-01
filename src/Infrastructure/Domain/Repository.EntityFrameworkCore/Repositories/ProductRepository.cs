using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
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