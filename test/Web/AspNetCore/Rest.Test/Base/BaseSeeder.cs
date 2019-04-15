using Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Base
{
    public abstract class BaseSeeder<T> : ISeeder
        where T : class
    {
        public async Task SeedAsync(NorthwindContext context)
        {
            var records = Create();

            foreach(var record in records)
            {
                var dbSet = context.Set<T>();
                dbSet.Add(record);
                await context.SaveChangesAsync();
            }
        }

        protected abstract List<T> Create();
    }
}
