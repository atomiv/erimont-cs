using Optivem.Platform.Core.Application.Service;
using Optivem.Northwind.Core.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IPurchaseOrderStatusService : ICrudService<PurchaseOrderStatusRequest, PurchaseOrderStatusResponse, int>
	{

	}
}
