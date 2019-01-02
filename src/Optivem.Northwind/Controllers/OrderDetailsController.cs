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
	[Route("api/orderdetails")]
	[ApiController]
	public class OrderDetailsController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IOrderDetailService service;

		public OrderDetailsController(INorthwindUnitOfWork unitOfWork, IOrderDetailService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetails()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<OrderDetail>> GetOrderDetail(string id)
		{
			string[] parts = SplitId(id);

			int orderId = int.Parse(parts[0]);
			int productId = int.Parse(parts[1]);

			var orderDetail = await service.GetAsync(orderId, productId);

			if (orderDetail == null)
			{
				return NotFound();
			}

			return orderDetail;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutOrderDetail(string id, OrderDetail orderDetail)
		{
			string[] parts = SplitId(id);

			int orderId = int.Parse(parts[0]);
			int productId = int.Parse(parts[1]);

			if (orderId != orderDetail.OrderId || productId != orderDetail.ProductId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(orderDetail);

				await unitOfWork.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!service.Exists(orderId, productId))
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
		public async Task<ActionResult<OrderDetail>> PostOrderDetail(OrderDetail orderDetail)
		{
			service.Add(orderDetail);

			await unitOfWork.SaveChangesAsync();

			string id = JoinId(orderDetail.OrderId.ToString(), orderDetail.ProductId.ToString());

			return CreatedAtAction("GetOrderDetail", new { id = id }, orderDetail);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<OrderDetail>> DeleteOrderDetail(string id)
		{
			string[] parts = SplitId(id);

			int orderId = int.Parse(parts[0]);
			int productId = int.Parse(parts[1]);

			var orderDetail = await service.GetAsync(orderId, productId);

			if (orderDetail == null)
			{
				return NotFound();
			}

			service.Delete(orderDetail);

			await unitOfWork.SaveChangesAsync();

			return orderDetail;
		}

		private string[] SplitId(string id)
		{
			string[] parts = id.Split("-");
			return parts;
		}

		private string JoinId(params string[] parts)
		{
			return string.Join("-", parts);
		}
	}
}
