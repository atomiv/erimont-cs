namespace Optivem.Northwind.Web.RestClient.Interface
{
    public interface IApiHttpService
    {
        ICustomerHttpService Customers { get; }

        IProductHttpService Products { get; }
    }
}
