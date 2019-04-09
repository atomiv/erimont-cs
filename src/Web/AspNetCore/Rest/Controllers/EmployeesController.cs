using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

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