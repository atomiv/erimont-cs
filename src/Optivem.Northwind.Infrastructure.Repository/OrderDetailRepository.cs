using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Commons.Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class OrderDetailRepository : EntityFrameworkRepository<NorthwindContext, OrderDetail, int, int>, IOrderDetailRepository
	{
		public OrderDetailRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
