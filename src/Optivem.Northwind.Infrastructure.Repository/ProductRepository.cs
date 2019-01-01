using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class ProductRepository : EntityFrameworkRepository<NorthwindContext, Product, int>, IProductRepository
	{
		public ProductRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
