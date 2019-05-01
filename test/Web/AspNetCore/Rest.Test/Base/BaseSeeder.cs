using Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Base
{
    public abstract class BaseSeeder<T> : ISeeder
        where T : class
    {
        public void Seed(NorthwindContext context)
        {
            var records = Create();

            foreach(var record in records)
            {
                var dbSet = context.Set<T>();
                dbSet.Add(record);
            }

            context.SaveChangesAsync();
        }

        protected abstract List<T> Create();
    }
}
