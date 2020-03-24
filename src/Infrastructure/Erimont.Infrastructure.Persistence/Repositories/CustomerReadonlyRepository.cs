using Microsoft.EntityFrameworkCore;
using Erimont.Core.Domain.Customers;
using System;
using System.Threading.Tasks;

namespace Erimont.Infrastructure.Persistence.Repositories
{
    public class CustomerReadonlyRepository : Repository, ICustomerReadonlyRepository
    {
        public CustomerReadonlyRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(Guid customerId)
        {
            return Context.Customers.AsNoTracking()
                .AnyAsync(e => e.Id == customerId);
        }

        public Task<long> CountAsync()
        {
            return Context.Customers.LongCountAsync();
        }
    }
}
