using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IRegionService
	{
		Task<IEnumerable<Region>> GetAsync();

		Task<Region> GetAsync(int id);

		void Add(Region region);

		void Update(Region region);

		void Delete(Region region);

		bool Exists(int id);
	}
}
