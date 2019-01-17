﻿using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class OrderStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderStatus, int>, IOrderStatusRepository
	{
		public OrderStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}