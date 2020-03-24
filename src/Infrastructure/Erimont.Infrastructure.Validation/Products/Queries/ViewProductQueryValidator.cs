using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using Erimont.Core.Application.Products.Queries;
using Erimont.Core.Domain.Products;

namespace Erimont.Infrastructure.Validation.Products.Queries
{
    public class ViewProductQueryValidator : BaseValidator<ViewProductQuery>
    {
        public ViewProductQueryValidator(IProductReadonlyRepository productReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((query, context, cancellation)
                    => productReadonlyRepository.ExistsAsync(query.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
