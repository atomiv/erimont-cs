# Optivem Northwind (C#)

[![Build Status](https://travis-ci.org/optivem/northwind-csharp.svg?branch=master)](https://travis-ci.org/optivem/northwind-csharp)

## Project structure

The following example illustrates the example for suppliers.

Step 1: Entity

Inside Optivem.Northwind.Core.Domain.Entity, we have:
* Supplier.cs

Step 2: Repository

Inside the project Optivem.Northwind.Core.Domain.Repository, create the repository interface:
* ISupplierRepository.cs

Inside the project Optivem.Northwind.Infrastructure.Repository, provide the implementation for that interface:
* SupplierRepository.cs

Step 3: Unit of Work

Inside the project Optivem.Northwind.Core.Domain.Repository, inside INorthwindUnitOfWork.cs, reference the following:
* ISupplierRepository SupplierRepository { get; }

Inside the project Optivem.Northwind.Infrastructure.Repository, inside NorthwindUnitOfWork.cs, reference the following:
* SupplierRepository = new SupplierRepository(context);
* ISupplierRepository SupplierRepository { get; }


Step 4: Service

Inside the project Optivem.Northwind.Core.Application.Service, we have the service interface:
* ISupplierService.cs

Inside the project Optivem.Northwind.Core.Application.Service, we have the service implementation:
* SupplierService

Step 5: IoC

Inside the project Optivem.Northwind, inside the class Startup.cs, add the following:
* services.AddScoped<ISupplierService, SupplierService>();

Step 6: Controller

Inside the project Optivem.Northwind, folder Controllers, we have the class (note the plural name):
* SuppliersController