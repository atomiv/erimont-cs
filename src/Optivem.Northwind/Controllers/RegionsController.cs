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
	[Route("api/regions")]
	[ApiController]
	public class RegionsController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IRegionService service;

		public RegionsController(INorthwindUnitOfWork unitOfWork, IRegionService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Region>>> GetRegions()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Region>> GetRegion(int id)
		{
			var region = await service.GetAsync(id);

			if (region == null)
			{
				return NotFound();
			}

			return region;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutRegion(int id, Region region)
		{
			if (id != region.RegionId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(region);

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
		public async Task<ActionResult<Region>> PostRegion(Region region)
		{
			service.Add(region);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetRegion", new { id = region.RegionId }, region);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Region>> DeleteRegion(int id)
		{
			var region = await service.GetAsync(id);

			if (region == null)
			{
				return NotFound();
			}

			service.Delete(region);

			await unitOfWork.SaveChangesAsync();

			return region;
		}
	}
}
