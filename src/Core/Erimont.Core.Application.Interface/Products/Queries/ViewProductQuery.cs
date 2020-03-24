using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Products.Queries
{
    public class ViewProductQuery : IRequest<ViewProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}