using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Base;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Seeders;
using Optivem.Northwind.Web.Rest;
using Optivem.Framework.Core.Common.Serialization;
using Optivem.Framework.Infrastructure.Common.RestClient.Default;
using Optivem.Framework.Infrastructure.Common.Serialization.Default;
using Optivem.Framework.Test.Xunit.Web.AspNetCore;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures
{
    public class RestTestServerFixture : TestServerFixture
    {
        private const string NorthwindContextConnectionStringKey = "Northwind";

        private static object contextLock = new object();

        // TODO: VC: Perhaps we could have abstract class for creating webHostBuilder

        // TODO: VC: This is duplication - CreateWebHostBuilder
        public RestTestServerFixture() : base(CreateWebHostBuilder())
        {
            var serializationService = new SerializationService();

            SuppliersControllerClient = new SuppliersControllerClient(HttpClient, serializationService);
            CustomersControllerClient = new CustomersControllerClient(HttpClient, serializationService);
        }

        public SuppliersControllerClient SuppliersControllerClient { get; }

        public CustomersControllerClient CustomersControllerClient { get; }

        private static IWebHostBuilder CreateWebHostBuilder()
        {
            // TODO: VC: Distinguish between startup which uses appsettings json vs one which does not

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.Test.json");

            var configuration = configurationBuilder
                .Build();


            // TODO: VC: Enable async method, seeding should be moved away from constructor...
            SeedDatabase(configuration);

            return new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configuration);
        }

        private static void SeedDatabase(IConfigurationRoot configuration)
        {
            var connection = configuration.GetConnectionString(NorthwindContextConnectionStringKey);

            var builder = new DbContextOptionsBuilder<NorthwindContext>()
                .UseSqlServer(connection);

            var seeders = new List<ISeeder>
            {
                new SupplierSeeder(),
            };

            lock(contextLock)
            {
                using (var context = new NorthwindContext(builder.Options))
                {
                    context.Database.EnsureCreated();

                    // TODO: VC: Seeding not working

                    /*
                    foreach (var seeder in seeders)
                    {
                        seeder.Seed(context);
                    }

                    context.SaveChanges();
                    */

                    // TODO: VC use seeding instead, exlictily settings ids etc
                    // TODO: VC: When running test, ensure to operate on separate parts of data, or create adhoc during test 
                }
            }
        }
    }

    public class SuppliersControllerClient
        : RestControllerClient<long, SupplierRequest, SupplierResponse>
    {
        public SuppliersControllerClient(HttpClient client, ISerializationService serializationService) 
            : base(client, "api/suppliers", serializationService)
        {
        }
    }

    public class CustomersControllerClient
        : RestControllerClient<long, CustomerRequest, CustomerResponse>
    {
        public CustomersControllerClient(HttpClient client, ISerializationService serializationService)
            : base(client, "api/customers", serializationService)
        {
        }
    }
}
