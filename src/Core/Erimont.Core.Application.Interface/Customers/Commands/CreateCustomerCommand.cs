using Optivem.Atomiv.Core.Application;

namespace Erimont.Core.Application.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<CreateCustomerCommandResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}