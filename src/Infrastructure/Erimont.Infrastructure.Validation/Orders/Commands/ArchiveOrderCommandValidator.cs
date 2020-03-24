using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Domain.Orders;

namespace Erimont.Infrastructure.Validation.Orders.Commands
{
    public class ArchiveOrderCommandValidator : BaseValidator<ArchiveOrderCommand>
    {
        public ArchiveOrderCommandValidator(IOrderReadonlyRepository orderReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => orderReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
