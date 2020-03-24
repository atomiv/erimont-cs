using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Customers.Queries
{
    public class ViewCustomerQuery : IRequest<ViewCustomerQueryResponse>
    {
        public Guid Id { get; set; }
    }
}