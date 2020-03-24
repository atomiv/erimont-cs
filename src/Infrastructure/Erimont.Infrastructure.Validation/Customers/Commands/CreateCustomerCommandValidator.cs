using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using Erimont.Core.Application.Customers.Commands;

namespace Erimont.Infrastructure.Validation.Customers
{
    public class CreateCustomerCommandValidator : BaseValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}