using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Core.Application.Service.Default;
using Optivem.Platform.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Service.Default
{
    public class OrderDetailStatusService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderDetailStatusRepository, OrderDetailStatusRequest, OrderDetailStatusResponse, OrderDetailStatus, int>, IOrderDetailStatusService
    {
        public OrderDetailStatusService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.OrderDetailStatusRepository)
        {
        }
    }
}