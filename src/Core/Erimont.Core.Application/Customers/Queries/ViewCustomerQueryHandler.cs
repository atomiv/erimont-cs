﻿using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Customers.Repositories;

namespace Erimont.Core.Application.Customers.Queries
{
    // TODO: VC: Make base class with AsNoTracking

    public class ViewCustomerQueryHandler : IRequestHandler<ViewCustomerQuery, ViewCustomerQueryResponse>
    {
        private readonly ICustomerQueryRepository _customerReadRepository;

        public ViewCustomerQueryHandler(ICustomerQueryRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<ViewCustomerQueryResponse> HandleAsync(ViewCustomerQuery request)
        {
            var customerDetail = await _customerReadRepository.QueryAsync(request);

            if (customerDetail == null)
            {
                throw new ExistenceException();
            }

            return customerDetail;
        }
    }
}