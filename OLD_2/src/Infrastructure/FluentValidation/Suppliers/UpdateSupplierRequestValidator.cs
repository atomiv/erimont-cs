using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.Northwind.Core.Application.Suppliers.Requests;

namespace Optivem.Northwind.Infrastructure.FluentValidation.Suppliers
{
    public class UpdateSupplierRequestValidator : BaseValidator<UpdateSupplierRequest>
    {
        public UpdateSupplierRequestValidator()
        {
            RuleFor(e => e.Company)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.LastName)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.FirstName)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.EmailAddress)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.JobTitle)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.BusinessPhone)
                .MaximumLength(25)
                .NotEmpty();

            RuleFor(e => e.HomePhone)
                .MaximumLength(25);

            RuleFor(e => e.MobilePhone)
                .MaximumLength(25)
                .NotEmpty();

            RuleFor(e => e.FaxNumber)
                .MaximumLength(25);

            // TODO: VC: Check because no length limit
            RuleFor(e => e.Address)
                .NotEmpty();

            RuleFor(e => e.City)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.StateProvince)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(e => e.ZipPostalCode)
                .MaximumLength(15)
                .NotEmpty();

            RuleFor(e => e.CountryRegion)
                .MaximumLength(50)
                .NotEmpty();

            // TODO: VC: Check because no length limit
            RuleFor(e => e.WebPage)
                .NotEmpty();

            // TODO: VC: Check because no length limit
            RuleFor(e => e.Notes)
                .NotEmpty();
        }
    }
}
