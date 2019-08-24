using Optivem.Framework.Core.Common.Http;
using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.Northwind.Web.RestClient.Interface;

namespace Optivem.Northwind.Web.RestClient.Http
{
    public class ApiHttpService : BaseApiClient, IApiHttpService
    {
        public ApiHttpService(IControllerClientFactory clientFactory)
            : base(clientFactory)
        {
            Customers = new CustomerHttpService(clientFactory);
            Products = new ProductHttpService(clientFactory);
        }

        public ICustomerHttpService Customers { get; }

        public IProductHttpService Products { get; }
    }
}
