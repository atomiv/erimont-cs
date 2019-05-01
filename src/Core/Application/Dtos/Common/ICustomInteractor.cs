using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Dtos.Common
{
    public interface ICustomInteractor<TRequest, TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }

    public interface ICustomInteractor<TRequest>
    {
        Task HandleAsync(TRequest request);
    }
}
