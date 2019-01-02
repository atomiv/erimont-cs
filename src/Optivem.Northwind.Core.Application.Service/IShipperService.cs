using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IShipperService
	{
		Task<IEnumerable<Shipper>> GetAsync();

		Task<Shipper> GetAsync(int id);

		void Add(Shipper shipper);

		void Update(Shipper shipper);

		void Delete(Shipper shipper);

		bool Exists(int id);
	}
}
