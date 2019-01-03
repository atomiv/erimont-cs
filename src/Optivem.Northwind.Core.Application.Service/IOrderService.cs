using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IOrderService
	{
		Task<IEnumerable<Order>> GetAsync();

		Task<Order> GetAsync(int id);

		void Add(Order order);

		void Update(Order order);

		void Delete(Order order);

		bool Exists(int id);
	}
}
