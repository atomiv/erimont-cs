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
	[Route("api/employees")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IEmployeeService service;

		public EmployeesController(INorthwindUnitOfWork unitOfWork, IEmployeeService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Employee>> GetEmployee(int id)
		{
			var employee = await service.GetAsync(id);

			if (employee == null)
			{
				return NotFound();
			}

			return employee;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutEmployee(int id, Employee employee)
		{
			if (id != employee.EmployeeId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(employee);

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
		public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
		{
			service.Add(employee);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetEmployee", new { id = employee.EmployeeId }, employee);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Employee>> DeleteEmployee(int id)
		{
			var employee = await service.GetAsync(id);

			if (employee == null)
			{
				return NotFound();
			}

			service.Delete(employee);

			await unitOfWork.SaveChangesAsync();

			return employee;
		}
	}
}
