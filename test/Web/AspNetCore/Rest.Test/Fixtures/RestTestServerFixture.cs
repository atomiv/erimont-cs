using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Base;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Seeders;
using Optivem.Northwind.Web.Rest;
using Optivem.Platform.Core.Common.Serialization;
using Optivem.Platform.Infrastructure.Common.RestClient.Default;
using Optivem.Platform.Infrastructure.Common.Serialization.Default;
using Optivem.Platform.Test.Xunit.Web.AspNetCore;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures
{
    public class RestTestServerFixture : TestServerFixture
    {
        private const string NorthwindContextConnectionStringKey = "Northwind";

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
            SeedDatabase(configuration).GetAwaiter().GetResult();

            return new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configuration);
        }

        private static async Task SeedDatabase(IConfigurationRoot configuration)
        {
            var connection = configuration.GetConnectionString(NorthwindContextConnectionStringKey);

            var builder = new DbContextOptionsBuilder<NorthwindContext>()
                .UseSqlServer(connection);

            var seeders = new List<ISeeder>
            {
                new SupplierSeeder(),
            };

            using (var context = new NorthwindContext(builder.Options))
            {
                context.Database.Migrate();

                foreach(var seeder in seeders)
                {
                    await seeder.SeedAsync(context);
                }

                await context.SaveChangesAsync();

                // TODO: VC use seeding instead, exlictily settings ids etc
                // TODO: VC: When running test, ensure to operate on separate parts of data, or create adhoc during test 
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
