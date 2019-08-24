using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.UseCases.SupplierUseCases.CreateSupplier
{
    public class CreateSupplierValidator : AbstractValidator<CreateSupplierRequest>
    {
        public CreateSupplierValidator()
        {
            RuleFor(e => e.FirstName).NotNull().NotEmpty();
            RuleFor(e => e.LastName).NotNull().NotEmpty();
        }
    }
}
