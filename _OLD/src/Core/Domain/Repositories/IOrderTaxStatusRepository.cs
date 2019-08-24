using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Framework.Core.Domain.Repositories;

namespace Optivem.Northwind.Core.Domain.Repositories
{
    public interface IOrderTaxStatusRepository : IRepository<OrderTaxStatus, int>
    {
    }
}