using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public class OrderDetailService : IOrderDetailService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IOrderDetailRepository repository;

		public OrderDetailService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.OrderDetailRepository;
		}

		public void Add(OrderDetail orderDetail)
		{
			repository.Add(orderDetail);
		}

		public void Delete(OrderDetail orderDetail)
		{
			repository.Delete(orderDetail);
		}

		public Task<IEnumerable<OrderDetail>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<OrderDetail> GetAsync(int orderId, int productId)
		{
			return repository.GetSingleOrDefaultAsync(orderId, productId);
		}

		public void Update(OrderDetail orderDetail)
		{
			repository.Update(orderDetail);
		}

		public bool Exists(int orderId, int productId)
		{
			return repository.GetExists(orderId, productId);
		}
	}
}
