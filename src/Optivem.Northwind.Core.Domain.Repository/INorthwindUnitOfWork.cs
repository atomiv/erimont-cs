using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface INorthwindUnitOfWork : IDisposable
    {
        ISupplierRepository SupplierRepository { get; }

        void Commit();
        Task CommitAsync();
    }
}
