using Optivem.Atomiv.Core.Application;

namespace Erimont.Core.Application.Products.Queries
{
    public class BrowseProductsQuery : IRequest<BrowseProductsQueryResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}