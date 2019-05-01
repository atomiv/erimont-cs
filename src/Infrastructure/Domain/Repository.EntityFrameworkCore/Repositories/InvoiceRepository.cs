using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class InvoiceRepository : EntityFrameworkRepository<NorthwindContext, Invoice, int>, IInvoiceRepository
    {
        public InvoiceRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}