using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Northwind.Infrastructure.Repository;

namespace Optivem.Northwind
{
    public class Startup
    {
        private const string NorthwindContextConnectionStringKey = "Northwind";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            var connection = Configuration.GetConnectionString(NorthwindContextConnectionStringKey);
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connection));

            // Unit of work
            services.AddScoped<INorthwindUnitOfWork, NorthwindUnitOfWork>();

            // Application services
            services.AddScoped<ISupplierService, SupplierService>();
			services.AddScoped<IProductService, ProductService>();

		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

		// TODO: JC: Test commit
    }
}
