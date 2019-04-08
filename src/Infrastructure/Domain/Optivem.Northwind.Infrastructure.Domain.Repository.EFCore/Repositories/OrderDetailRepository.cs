﻿using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class OrderDetailRepository : EntityFrameworkRepository<NorthwindContext, OrderDetail, int>, IOrderDetailRepository
	{
		public OrderDetailRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
