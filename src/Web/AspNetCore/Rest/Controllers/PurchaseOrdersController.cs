using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/purchase-orders")]
    [ApiController]
    public class PurchaseOrdersController : AspNetCoreCrudController<INorthwindUnitOfWork, IPurchaseOrderService, PurchaseOrderRequest, PurchaseOrderResponse, int>
    {
        public PurchaseOrdersController(INorthwindUnitOfWork unitOfWork, IPurchaseOrderService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}