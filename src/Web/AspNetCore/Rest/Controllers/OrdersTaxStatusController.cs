﻿using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

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