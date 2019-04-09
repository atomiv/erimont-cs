using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Core.Application.Service.Default;
using Optivem.Platform.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Service.Default
{
    public class CustomerService : CrudService<IMappingService, INorthwindUnitOfWork, ICustomerRepository, CustomerRequest, CustomerResponse, Customer, int>, ICustomerService
    {
        public CustomerService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.CustomerRepository)
        {
        }
    }
}