using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class OrderDetailService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderDetailRepository, OrderDetailRequest, OrderDetailResponse, OrderDetail, int>, IOrderDetailService
    {
        public OrderDetailService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.OrderDetailRepository)
        {
        }
    }
}