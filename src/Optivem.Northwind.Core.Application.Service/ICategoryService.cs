using Optivem.Northwind.Core.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAsync();

		Task<Category> GetAsync(int id);

		void Add(Category category);

		void Update(Category category);

		void Delete(Category category);

		bool Exists(int id);
	}
}
