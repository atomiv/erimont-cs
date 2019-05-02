using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/purchase-order-details")]
    [ApiController]
    public class PurchaseOrderDetailsController : AspNetCoreCrudController<INorthwindUnitOfWork, IPurchaseOrderDetailService, PurchaseOrderDetailRequest, PurchaseOrderDetailResponse, int>
    {
        public PurchaseOrderDetailsController(INorthwindUnitOfWork unitOfWork, IPurchaseOrderDetailService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}