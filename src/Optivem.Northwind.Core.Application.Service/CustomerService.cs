using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Commons.Mapping;
using Optivem.Commons.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class CustomerService : CrudService<IMappingService, INorthwindUnitOfWork, ICustomerRepository, CustomerRequest, CustomerResponse, Customer, int>, ICustomerService
	{
		public CustomerService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.CustomerRepository)
		{

		}
	}
}
