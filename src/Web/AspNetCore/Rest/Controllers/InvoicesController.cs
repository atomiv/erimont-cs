using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : AspNetCoreCrudController<INorthwindUnitOfWork, IInvoiceService, InvoiceRequest, InvoiceResponse, int>
    {
        public InvoicesController(INorthwindUnitOfWork unitOfWork, IInvoiceService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}