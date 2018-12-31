using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Northwind.Infrastructure.Repository;

namespace Optivem.Northwind.Controllers
{
	[Route("api/categories")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly ICategoryService service;

		public CategoriesController(INorthwindUnitOfWork unitOfWork, ICategoryService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Category>> GetCategory(int id)
		{
			var category = await service.GetAsync(id);

			if (category == null)
			{
				return NotFound();
			}

			return category;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutCategory(int id, Category category)
		{
			if (id != category.CategoryId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(category);

				await unitOfWork.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!service.Exists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<Category>> PostCategory(Category category)
		{
			service.Add(category);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Category>> DeleteCategory(int id)
		{
			var category = await service.GetAsync(id);

			if (category == null)
			{
				return NotFound();
			}

			service.Delete(category);

			await unitOfWork.SaveChangesAsync();

			return category;
		}
	}
}
