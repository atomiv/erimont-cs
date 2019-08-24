using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Orders.Responses
{
    public class FindOrderResponse : IResponse<int>
    {
        public int Id { get; set; }
    }
}
