using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class CategoryService : ICategoryService
	{
		private INorthwindUnitOfWork unitOfWork;
		private ICategoryRepository repository;

		public CategoryService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.CategoryRepository;
		}

		public void Add(Category category)
		{
			repository.Add(category);
		}

		public void Delete(Category category)
		{
			repository.Delete(category);
		}

		public Task<IEnumerable<Category>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Category> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Category category)
		{
			repository.Update(category);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
