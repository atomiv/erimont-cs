using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Platform.Web.AspNetCore.Rest;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : AspNetCoreCrudController<INorthwindUnitOfWork, ISupplierService, SupplierRequest, SupplierResponse, int>
    {
        public SuppliersController(INorthwindUnitOfWork unitOfWork, ISupplierService service) 
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {

        }
    }
}