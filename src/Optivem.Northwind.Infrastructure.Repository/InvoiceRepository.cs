using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class InvoiceRepository : EntityFrameworkRepository<NorthwindContext, Invoice, int>, IInvoiceRepository
	{
		public InvoiceRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
