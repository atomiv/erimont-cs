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
	[Route("api/orders")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IOrderService service;

		public OrdersController(INorthwindUnitOfWork unitOfWork, IOrderService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Order>> GetOrder(int id)
		{
			var order = await service.GetAsync(id);

			if (order == null)
			{
				return NotFound();
			}

			return order;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutOrder(int id, Order order)
		{
			if (id != order.OrderId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(order);

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
		public async Task<ActionResult<Order>> PostOrder(Order order)
		{
			service.Add(order);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Order>> DeleteOrder(int id)
		{
			var order = await service.GetAsync(id);

			if (order == null)
			{
				return NotFound();
			}

			service.Delete(order);

			await unitOfWork.SaveChangesAsync();

			return order;
		}
	}
}
