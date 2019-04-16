using Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Base
{
    public interface ISeeder
    {
        void Seed(NorthwindContext context);
    }
}
