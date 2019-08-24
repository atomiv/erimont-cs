using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Customers.Requests;
using Optivem.Northwind.Core.Application.Customers.Responses;
using Optivem.Northwind.Core.Domain.Customers.Entities;
using Optivem.Northwind.Core.Domain.Customers.Repositories;
using Optivem.Northwind.Core.Domain.Customers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Customers.UseCases
{
    public class ListCustomersUseCase : ListAggregatesUseCase<ICustomerRepository, ListCustomersRequest, ListCustomersResponse, ListCustomersRecordResponse, Customer, CustomerIdentity, int>
    {
        public ListCustomersUseCase(ICustomerRepository repository, ICollectionResponseMapper<Customer, ListCustomersResponse> responseMapper) 
            : base(repository, responseMapper)
        {
        }
    }
}