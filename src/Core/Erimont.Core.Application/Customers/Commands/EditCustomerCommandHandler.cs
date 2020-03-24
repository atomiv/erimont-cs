﻿using Optivem.Atomiv.Core.Application;
using Erimont.Core.Domain.Customers;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Customers.Commands
{
    public class EditCustomerCommandHandler : IRequestHandler<EditCustomerCommand, EditCustomerCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public EditCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<EditCustomerCommandResponse> HandleAsync(EditCustomerCommand request)
        {
            var customerId = new CustomerIdentity(request.Id);

            var customer = await _customerRepository.FindAsync(customerId);

            UpdateCustomer(customer, request);

            await _customerRepository.UpdateAsync(customer);
            return _mapper.Map<Customer, EditCustomerCommandResponse>(customer);
        }

        private void UpdateCustomer(Customer customer, EditCustomerCommand request)
        {
            customer.FirstName = request.FirstName;
            customer.LastName = request.LastName;
        }
    }
}