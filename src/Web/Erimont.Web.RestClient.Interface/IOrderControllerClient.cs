using Optivem.Atomiv.Core.Common.Http;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Application.Orders.Queries;
using System.Threading.Tasks;

namespace Erimont.Web.RestClient.Interface
{
    public interface IOrderControllerClient : IHttpControllerClient
    {
        #region Commands

        Task<IObjectClientResponse<ArchiveOrderCommandResponse>> ArchiveOrderAsync(ArchiveOrderCommand request);

        Task<IObjectClientResponse<CancelOrderCommandResponse>> CancelOrderAsync(CancelOrderCommand request);

        Task<IObjectClientResponse<CreateOrderCommandResponse>> CreateOrderAsync(CreateOrderCommand request);

        Task<IObjectClientResponse<EditOrderCommandResponse>> EditOrderAsync(EditOrderCommand request);

        Task<IObjectClientResponse<SubmitOrderCommandResponse>> SubmitOrderAsync(SubmitOrderCommand request);

        #endregion

        #region Queries

        Task<IObjectClientResponse<BrowseOrdersQueryResponse>> BrowseOrdersAsync(BrowseOrdersQuery request);

        Task<IObjectClientResponse<FilterOrdersQueryResponse>> FilterOrdersAsync(FilterOrdersQuery request);

        Task<IObjectClientResponse<ViewOrderQueryResponse>> ViewOrderAsync(ViewOrderQuery request);

        #endregion
    }
}
