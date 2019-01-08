using Optivem.Commons.Persistence;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface INorthwindUnitOfWork : IUnitOfWork
    {
        ISupplierRepository SupplierRepository { get; }
	}
}
