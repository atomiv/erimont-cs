using Microsoft.AspNetCore.Mvc;
using Optivem.Framework.Web.AspNetCore;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Application.Suppliers.Services;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.RestApi.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : BaseController<ISupplierService>
    {
        public SuppliersController(ISupplierService service)
            : base(service)
        {
        }

        [HttpGet(Name ="list-suppliers")]
        [ProducesResponseType(typeof(ListSuppliersResponse), 200)]
        public async Task<ActionResult<ListSuppliersResponse>> ListSuppliersAsync()
        {
            var request = new ListSuppliersRequest();
            var response = await Service.ListSuppliersAsync(request);
            return Ok(response);
        }

        // TODO: VC: Check swagger global responses, e.g. for validation?

        [HttpGet("{id}", Name = "find-supplier")]
        [ProducesResponseType(typeof(FindSupplierResponse), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<FindSupplierResponse>> FindSupplierAsync(int id)
        {
            var request = new FindSupplierRequest { Id = id };
            var response = await Service.FindSupplierAsync(request);
            return Ok(response);
        }

        [HttpPost(Name ="create-supplier")]
        [ProducesResponseType(typeof(CreateSupplierResponse), 201)]
        public async Task<ActionResult<CreateSupplierResponse>> CreateSupplierAsync(CreateSupplierRequest request)
        {
            var response = await Service.CreateSupplierAsync(request);
            return CreatedAtRoute("find-supplier", new { id = response.Id }, response);
        }

        [HttpPut("{id}", Name = "update-supplier")]
        [ProducesResponseType(typeof(UpdateSupplierResponse), 201)]
        public async Task<ActionResult<UpdateSupplierResponse>> UpdateSupplierAsync(int id, UpdateSupplierRequest request)
        {
            // TODO: VC: API validation regarding id matching

            var response = await Service.UpdateSupplierAsync(request);
            return Ok(response);
        }

        [HttpDelete("{id}", Name = "delete-supplier")]
        public async Task<ActionResult> DeleteSupplierAsync(int id)
        {
            var request = new DeleteSupplierRequest { Id = id };
            var response = await Service.DeleteSupplierAsync(request);
            return NoContent();
        }
    }
}