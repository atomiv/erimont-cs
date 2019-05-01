using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier
{
    public class CreateSupplierValidator : AbstractValidator<CreateSupplierRequest>
    {
        public CreateSupplierValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty();
            RuleFor(e => e.LastName).NotEmpty();
        }
    }
}
