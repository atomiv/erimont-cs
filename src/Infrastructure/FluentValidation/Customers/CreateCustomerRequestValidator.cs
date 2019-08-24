using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Northwind.Core.Application.Customers.Requests;

namespace Optivem.Northwind.Infrastructure.FluentValidation.Customers
{
    public class CreateCustomerRequestValidator : BaseValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}
