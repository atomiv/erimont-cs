using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class CustomerRepository : EntityFrameworkRepository<NorthwindContext, Customer, int>, ICustomerRepository
    {
        public CustomerRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}