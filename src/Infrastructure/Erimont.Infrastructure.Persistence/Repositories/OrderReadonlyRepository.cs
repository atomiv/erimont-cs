using Microsoft.EntityFrameworkCore;
using Erimont.Core.Domain.Orders;
using System;
using System.Threading.Tasks;

namespace Erimont.Infrastructure.Persistence.Repositories
{
    public class OrderReadonlyRepository : Repository, IOrderReadonlyRepository
    {
        public OrderReadonlyRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(Guid orderId)
        {
            return Context.Orders.AsNoTracking()
                .AnyAsync(e => e.Id == orderId);
        }

        public Task<long> CountAsync()
        {
            return Context.Orders.LongCountAsync();
        }
    }
}
