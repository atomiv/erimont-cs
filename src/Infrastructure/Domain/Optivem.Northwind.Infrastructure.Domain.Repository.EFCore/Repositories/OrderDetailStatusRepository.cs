﻿using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class OrderDetailStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderDetailStatus, int>, IOrderDetailStatusRepository
	{
		public OrderDetailStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
