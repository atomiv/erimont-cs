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
	[Route("api/territories")]
	[ApiController]
	public class TerritoriesController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly ITerritoryService service;

		public TerritoriesController(INorthwindUnitOfWork unitOfWork, ITerritoryService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Territory>>> GetTerritories()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Territory>> GetTerritory(string id)
		{
			var territory = await service.GetAsync(id);

			if (territory == null)
			{
				return NotFound();
			}

			return territory;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutTerritory(string id, Territory territory)
		{
			if (id != territory.TerritoryId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(territory);

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
		public async Task<ActionResult<Territory>> PostTerritory(Territory territory)
		{
			service.Add(territory);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetTerritory", new { id = territory.TerritoryId }, territory);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Territory>> DeleteTerritory(string id)
		{
			var territory = await service.GetAsync(id);

			if (territory == null)
			{
				return NotFound();
			}

			service.Delete(territory);

			await unitOfWork.SaveChangesAsync();

			return territory;
		}
	}
}
