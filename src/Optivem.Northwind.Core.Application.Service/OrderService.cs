using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class OrderService : IOrderService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IOrderRepository repository;

		public OrderService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.OrderRepository;
		}

		public void Add(Order order)
		{
			repository.Add(order);
		}

		public void Delete(Order order)
		{
			repository.Delete(order);
		}

		public Task<IEnumerable<Order>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Order> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Order order)
		{
			repository.Update(order);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
