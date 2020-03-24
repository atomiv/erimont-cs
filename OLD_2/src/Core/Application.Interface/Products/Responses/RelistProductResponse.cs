using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Products.Responses
{
    public class RelistProductResponse : IResponse<int>
    {
        public int Id { get; set; }
    }
}
