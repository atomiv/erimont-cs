﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Customers.Requests;
using Optivem.Northwind.Core.Application.Customers.Responses;
using Optivem.Northwind.Core.Domain.Customers.Entities;
using Optivem.Northwind.Core.Domain.Customers.Repositories;
using Optivem.Northwind.Core.Domain.Customers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Customers.UseCases
{
    public class CreateCustomerUseCase : CreateAggregateUseCase<ICustomerRepository, CreateCustomerRequest, CreateCustomerResponse, Customer, CustomerIdentity, int>
    {
        public CreateCustomerUseCase(IUnitOfWork unitOfWork, IResponseMapper<Customer, CreateCustomerResponse> responseMapper)
            : base(unitOfWork, responseMapper)
        {
        }

        // TODO: VC: Check possibiluty of factory, and then it will be internally able to also set the id

        protected override Customer CreateAggregateRoot(Customer aggregateRoot, CustomerIdentity identity)
        {
            return new Customer(identity, aggregateRoot.FirstName, aggregateRoot.LastName);
        }

        protected override Customer CreateAggregateRoot(CreateCustomerRequest request)
        {
            return new Customer(CustomerIdentity.Null, request.FirstName, request.LastName);
        }
    }
}