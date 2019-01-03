using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IOrderDetailService
	{
		Task<IEnumerable<OrderDetail>> GetAsync();

		Task<OrderDetail> GetAsync(int orderId, int productId);

		void Add(OrderDetail orderDetail);

		void Update(OrderDetail orderDetail);

		void Delete(OrderDetail orderDetail);

		bool Exists(int orderId, int productId);
	}
}
