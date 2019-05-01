using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class ShipperService : CrudService<IMappingService, INorthwindUnitOfWork, IShipperRepository, ShipperRequest, ShipperResponse, Shipper, int>, IShipperService
    {
        public ShipperService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.ShipperRepository)
        {
        }
    }
}