using Optivem.Framework.Core.Domain;
using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Customers.Repositories;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Customers.Repositories;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore
{
    public class UnitOfWork : UnitOfWork<DatabaseContext>, IUnitOfWork
    {
        public UnitOfWork(DatabaseContext context, bool disposeContext = false)
            : base(context, disposeContext)
        {
            AddRepository<ICustomerRepository>(new CustomerRepository(context));
        }
    }
}
