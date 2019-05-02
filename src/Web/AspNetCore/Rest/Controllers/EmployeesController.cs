using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : AspNetCoreCrudController<INorthwindUnitOfWork, IEmployeeService, EmployeeRequest, EmployeeResponse, int>
    {
        public EmployeesController(INorthwindUnitOfWork unitOfWork, IEmployeeService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}