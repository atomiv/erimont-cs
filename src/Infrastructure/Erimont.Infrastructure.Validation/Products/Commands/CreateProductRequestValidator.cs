using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using Erimont.Core.Application.Products.Commands;

namespace Erimont.Infrastructure.Validation.Products
{
    public class CreateProductRequestValidator : BaseValidator<CreateProductCommand>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(e => e.Code).NotNull();
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}