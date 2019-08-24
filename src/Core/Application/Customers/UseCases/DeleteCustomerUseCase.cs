using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Customers.Requests;
using Optivem.Northwind.Core.Application.Customers.Responses;
using Optivem.Northwind.Core.Domain.Customers.Entities;
using Optivem.Northwind.Core.Domain.Customers.Repositories;
using Optivem.Northwind.Core.Domain.Customers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Customers.UseCases
{
    public class DeleteCustomerUseCase : DeleteAggregateCase<ICustomerRepository, DeleteCustomerRequest, DeleteCustomerResponse, Customer, CustomerIdentity, int>
    {
        public DeleteCustomerUseCase(IUnitOfWork unitOfWork, IIdentityFactory<CustomerIdentity, int> identityFactory) 
            : base(unitOfWork, identityFactory)
        {
        }
    }
}
