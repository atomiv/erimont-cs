using Optivem.Atomiv.Core.Domain;

namespace Erimont.Core.Domain.Customers
{
    public interface ICustomerFactory : IFactory
    {
        Customer Create(string firstName, string lastName);
    }
}
