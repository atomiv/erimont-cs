using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/ inventory-transaction-types")]
    [ApiController]
    public class InventoryTransactionTypesController : AspNetCoreCrudController<INorthwindUnitOfWork, IInventoryTransactionTypeService, InventoryTransactionTypeRequest, InventoryTransactionTypeResponse, int>
    {
        public InventoryTransactionTypesController(INorthwindUnitOfWork unitOfWork, IInventoryTransactionTypeService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}