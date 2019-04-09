using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/purchase-orders-status")]
    [ApiController]
    public class PurchaseOrdersStatusController : AspNetCoreCrudController<INorthwindUnitOfWork, IPurchaseOrderStatusService, PurchaseOrderStatusRequest, PurchaseOrderStatusResponse, int>
    {
        public PurchaseOrdersStatusController(INorthwindUnitOfWork unitOfWork, IPurchaseOrderStatusService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}