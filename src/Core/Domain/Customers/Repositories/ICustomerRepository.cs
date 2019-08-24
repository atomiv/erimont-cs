using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Customers.Entities;
using Optivem.Northwind.Core.Domain.Customers.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Customers.Repositories
{
    public interface ICustomerRepository : ICrudRepository<Customer, CustomerIdentity>
    {
    }
}