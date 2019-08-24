using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Orders.Responses
{
    public class CreateOrderResponse : IResponse<int>
    {
        public int Id { get; set; }
    }
}
