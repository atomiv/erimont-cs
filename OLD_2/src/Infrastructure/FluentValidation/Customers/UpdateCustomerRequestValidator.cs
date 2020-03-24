using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Northwind.Core.Application.Customers.Requests;

namespace Optivem.Northwind.Infrastructure.FluentValidation.Customers
{
    public class UpdateCustomerRequestValidator : BaseValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}
