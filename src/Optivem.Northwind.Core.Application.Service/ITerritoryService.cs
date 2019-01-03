using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface ITerritoryService
	{
		Task<IEnumerable<Territory>> GetAsync();

		Task<Territory> GetAsync(string id);

		void Add(Territory territory);

		void Update(Territory territory);

		void Delete(Territory territory);

		bool Exists(string id);
	}
}
