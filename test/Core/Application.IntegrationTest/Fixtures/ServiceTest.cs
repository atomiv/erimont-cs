using Optivem.Framework.Test.Xunit;
using System;

namespace Optivem.Northwind.Core.Application.IntegrationTest.Fixtures
{
    public class ServiceTest : FixtureTest<ServiceFixture>, IDisposable
    {
        public ServiceTest(ServiceFixture fixture)
            : base(fixture)
        {
        }

        public void Dispose()
        {
            // TODO: VC: Optimize, use truncate, also generic truncate for all DB contexts, but only the operational tables

            using (var context = Fixture.Db.CreateContext())
            {
                context.Customers.RemoveRange(context.Customers);
                context.Products.RemoveRange(context.Products);
                context.Suppliers.RemoveRange(context.Suppliers);
                context.SaveChanges();
            }
        }
    }
}
