using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Repository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class NorthwindUnitOfWork : EntityFrameworkUnitOfWork<NorthwindContext>, INorthwindUnitOfWork
    {
        public NorthwindUnitOfWork(NorthwindContext context)
            : base(context)
        {
            SupplierRepository = new SupplierRepository(context);
			ProductRepository = new ProductRepository(context);
		}

        public ISupplierRepository SupplierRepository { get; private set; }

		public IProductRepository ProductRepository { get; private set; }


	}
}
