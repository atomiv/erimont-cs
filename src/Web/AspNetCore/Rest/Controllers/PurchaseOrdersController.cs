using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

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