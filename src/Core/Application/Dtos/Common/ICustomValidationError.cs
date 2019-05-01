using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Core.Application.Dtos.Common
{
    public interface ICustomValidationError
    {
        string Message { get; }

        string Details { get; }
    }
}
