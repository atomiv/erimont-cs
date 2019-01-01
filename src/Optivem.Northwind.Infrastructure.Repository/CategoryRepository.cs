using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class CategoryRepository : EntityFrameworkRepository<NorthwindContext, Category, int>, ICategoryRepository
	{
		public CategoryRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
