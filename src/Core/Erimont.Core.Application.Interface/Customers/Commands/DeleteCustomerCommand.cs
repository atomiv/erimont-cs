using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Customers.Commands
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerCommandResponse>
    {
        public Guid Id { get; set; }
    }
}