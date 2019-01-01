using Optivem.Northwind.Core.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface IProductService
	{
		Task<IEnumerable<Product>> GetAsync();

		Task<Product> GetAsync(int id);

		void Add(Product product);

		void Update(Product product);

		void Delete(Product product);

		bool Exists(int id);
	}
}
