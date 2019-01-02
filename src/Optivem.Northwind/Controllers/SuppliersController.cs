using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly INorthwindUnitOfWork unitOfWork;
        private readonly ISupplierService service;

        public SuppliersController(INorthwindUnitOfWork unitOfWork, ISupplierService service)
        {
            this.unitOfWork = unitOfWork;
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierResponse>>> GetSuppliers()
        {
            var result = await service.GetAsync();
            return result.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierResponse>> GetSupplier(int id)
        {
            var supplier = await service.GetAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, SupplierRequest supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }
            
            try
            {
                service.Update(supplier);

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
        public async Task<ActionResult<SupplierRequest>> PostSupplier(SupplierRequest supplier)
        {
            var result = service.Add(supplier);

            await unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SupplierRequest>> DeleteSupplier(int id)
        {
            var exists = service.Exists(id);
            
            if (!exists)
            {
                return NotFound();
            }
            
            service.Delete(id);

            await unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}