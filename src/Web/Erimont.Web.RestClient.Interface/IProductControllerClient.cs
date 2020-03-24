using Optivem.Atomiv.Core.Common.Http;
using Erimont.Core.Application.Products.Commands;
using Erimont.Core.Application.Products.Queries;
using System.Threading.Tasks;

namespace Erimont.Web.RestClient.Interface
{
    public interface IProductControllerClient : IHttpControllerClient
    {
        #region Commands

        Task<IObjectClientResponse<CreateProductCommandResponse>> CreateProductAsync(CreateProductCommand request);

        Task<IObjectClientResponse<EditProductCommandResponse>> EditProductAsync(EditProductCommand request);

        Task<IObjectClientResponse<RelistProductCommandResponse>> RelistProductAsync(RelistProductCommand request);

        Task<IObjectClientResponse<UnlistProductCommandResponse>> UnlistProductAsync(UnlistProductCommand request);

        #endregion

        #region Queries

        Task<IObjectClientResponse<BrowseProductsQueryResponse>> BrowseProductsAsync(BrowseProductsQuery request);

        Task<IObjectClientResponse<FilterProductsQueryResponse>> FilterProductsAsync(FilterProductsQuery request);

        Task<IObjectClientResponse<ViewProductQueryResponse>> ViewProductAsync(ViewProductQuery request);

        #endregion
    }
}