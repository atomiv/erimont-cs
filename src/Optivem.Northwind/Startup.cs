using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Application.Service.Default;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper;
using Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore;
using Optivem.Platform.Core.Common.Mapping;
using Optivem.Platform.Infrastructure.Common.Mapping.AutoMapper;
using Swashbuckle.AspNetCore.Swagger;

namespace Optivem.Northwind.Web.Rest
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
            // MVC
            services.AddMvc();

			// Register the Swagger generator, defining 1 or more Swagger documents
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
			});

			// CORS

			services.AddCors();

            // Mapping
            services.AddAutoMapper(e =>
            {
                e.AddProfile(new SupplierRequestMapping());
                e.AddProfile(new SupplierResponseMapping());
				e.AddProfile(new CustomerRequestMapping());
				e.AddProfile(new CustomerResponseMapping());
				e.AddProfile(new EmployeeRequestMapping());
				e.AddProfile(new EmployeeResponseMapping());
				e.AddProfile(new EmployeePrivilegeRequestMapping());
				e.AddProfile(new EmployeePrivilegeResponseMapping());
				e.AddProfile(new InventoryTransactionRequestMapping());
				e.AddProfile(new InventoryTransactionResponseMapping());
				e.AddProfile(new InventoryTransactionTypeRequestMapping());
				e.AddProfile(new InventoryTransactionTypeResponseMapping());
				e.AddProfile(new InvoiceRequestMapping());
				e.AddProfile(new InvoiceResponseMapping());
				e.AddProfile(new OrderDetailRequestMapping());
				e.AddProfile(new OrderDetailResponseMapping());
				e.AddProfile(new OrderDetailStatusRequestMapping());
				e.AddProfile(new OrderDetailStatusResponseMapping());
				e.AddProfile(new OrderStatusRequestMapping());
				e.AddProfile(new OrderStatusResponseMapping());
				e.AddProfile(new OrderTaxStatusRequestMapping());
				e.AddProfile(new OrderTaxStatusResponseMapping());
				e.AddProfile(new PrivilegeRequestMapping());
				e.AddProfile(new PrivilegeResponseMapping());
				e.AddProfile(new ProductRequestMapping());
				e.AddProfile(new ProductResponseMapping());
				e.AddProfile(new PurchaseOrderRequestMapping());
				e.AddProfile(new PurchaseOrderResponseMapping());
				e.AddProfile(new PurchaseOrderDetailRequestMapping());
				e.AddProfile(new PurchaseOrderDetailResponseMapping());
				e.AddProfile(new PurchaseOrderStatusRequestMapping());
				e.AddProfile(new PurchaseOrderStatusResponseMapping());
				e.AddProfile(new ShipperRequestMapping());
				e.AddProfile(new ShipperResponseMapping());

			});

            services.AddScoped<IMappingService, AutoMapperMappingService>();

            // DB Context
            var connection = Configuration.GetConnectionString(NorthwindContextConnectionStringKey);
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connection));

            // Unit of work
            services.AddScoped<INorthwindUnitOfWork, NorthwindUnitOfWork>();

            // Application services
            services.AddScoped<ISupplierService, SupplierService>();
			services.AddScoped<ICustomerService, CustomerService>();
			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IEmployeePrivilegeService, EmployeePrivilegeService>();
			services.AddScoped<IInventoryTransactionService, InventoryTransactionService>();
			services.AddScoped<IInventoryTransactionTypeService, InventoryTransactionTypeService>();
			services.AddScoped<IInvoiceService, InvoiceService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IOrderDetailService, OrderDetailService>();
			services.AddScoped<IOrderDetailStatusService, OrderDetailStatusService>();
			services.AddScoped<IOrderStatusService, OrderStatusService>();
			services.AddScoped<IOrderTaxStatusService, OrderTaxStatusService>();
			services.AddScoped<IPrivilegeService, PrivilegeService>();
			services.AddScoped<IProductService, ProductService>();
			services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
			services.AddScoped<IPurchaseOrderDetailService, PurchaseOrderDetailService>();
			services.AddScoped<IPurchaseOrderStatusService, PurchaseOrderStatusService>();
			services.AddScoped<IShipperService, ShipperService>();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            });

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});

			app.UseMvc();


        }
    }
}
