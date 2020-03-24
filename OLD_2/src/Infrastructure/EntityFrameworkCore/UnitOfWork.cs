using Optivem.Framework.Core.Domain;
using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Customers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Customers.Repositories;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Repositories;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore
{
    public class UnitOfWork : UnitOfWork<DatabaseContext>, IUnitOfWork
    {
        public UnitOfWork(DatabaseContext context, bool disposeContext = false)
            : base(context, disposeContext)
        {
            // TODO: VC: Instead of this, consider just injecting the repositories into use cases
            // and keeping unit of work just for save

            AddRepository<ICustomerRepository>(new CustomerRepository(context));
            AddRepository<ISupplierRepository>(new SupplierRepository(context));
        }
    }
}
