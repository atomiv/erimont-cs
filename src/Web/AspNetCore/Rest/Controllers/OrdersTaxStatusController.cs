using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/orders-tax-status")]
    [ApiController]
    public class OrdersTaxStatusController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderTaxStatusService, OrderTaxStatusRequest, OrderTaxStatusResponse, int>
    {
        public OrdersTaxStatusController(INorthwindUnitOfWork unitOfWork, IOrderTaxStatusService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}