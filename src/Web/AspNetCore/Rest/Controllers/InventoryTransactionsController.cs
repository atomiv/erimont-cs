using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/inventory-transactions")]
    [ApiController]
    public class InventoryTransactionsController : AspNetCoreCrudController<INorthwindUnitOfWork, IInventoryTransactionService, InventoryTransactionRequest, InventoryTransactionResponse, int>
    {
        public InventoryTransactionsController(INorthwindUnitOfWork unitOfWork, IInventoryTransactionService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}