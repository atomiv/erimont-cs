using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.UseCases.Behaviors
{
    // TODO: VC: Move into base
    public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly List<IValidator<TRequest>> _validators;

        public ValidatorBehavior(List<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var errors = _validators
                .Select(e => e.Validate(request))
                .SelectMany(e => e.Errors)
                .ToList();

            // TODO: VC: Check if need where error != null

            if (errors.Any())
            {
                // TODO: VC: Validation exception, pass the errors into constructor
                throw new Exception();
            }

            return await next();
        }
    }
}
