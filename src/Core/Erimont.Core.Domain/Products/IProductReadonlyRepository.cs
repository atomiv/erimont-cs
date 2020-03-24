using Optivem.Atomiv.Core.Domain;
using System;
using System.Threading.Tasks;

namespace Erimont.Core.Domain.Products
{
    public interface IProductReadonlyRepository : IRepository
    {
        Task<bool> ExistsAsync(Guid productId);

        Task<long> CountAsync();

        Task<decimal?> GetPriceAsync(Guid productId);
    }
}
