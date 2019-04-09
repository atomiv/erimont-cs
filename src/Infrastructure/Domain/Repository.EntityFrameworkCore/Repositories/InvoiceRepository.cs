using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class InvoiceRepository : EntityFrameworkRepository<NorthwindContext, Invoice, int>, IInvoiceRepository
    {
        public InvoiceRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}