using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class ProductService : IProductService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IProductRepository repository;

		public ProductService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.ProductRepository;
		}

		public void Add(Product product)
		{
			repository.Add(product);
		}

		public void Delete(Product product)
		{
			repository.Delete(product);
		}

		public Task<IEnumerable<Product>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Product> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Product product)
		{
			repository.Update(product);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
