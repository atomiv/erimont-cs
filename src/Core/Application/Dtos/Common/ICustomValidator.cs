using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Dtos.Common
{
    public interface ICustomValidator<TRequest>
    {
        List<ICustomValidationError> Validate(TRequest request);
    }
}
