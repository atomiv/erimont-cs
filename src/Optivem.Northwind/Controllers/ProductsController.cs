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
	[Route("api/products")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IProductService service;

		public ProductsController(INorthwindUnitOfWork unitOfWork, IProductService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			var product = await service.GetAsync(id);

			if (product == null)
			{
				return NotFound();
			}

			return product;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutProduct(int id, Product product)
		{
			if (id != product.ProductId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(product);

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
		public async Task<ActionResult<Product>> PostProduct(Product product)
		{
			service.Add(product);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Product>> DeleteProduct(int id)
		{
			var product = await service.GetAsync(id);

			if (product == null)
			{
				return NotFound();
			}

			service.Delete(product);

			await unitOfWork.SaveChangesAsync();

			return product;
		}
	}
}