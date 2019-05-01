using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
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