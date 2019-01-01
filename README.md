# Optivem Northwind (C#)

[![Build Status](https://travis-ci.org/optivem/northwind-csharp.svg?branch=master)](https://travis-ci.org/optivem/northwind-csharp)

## Documentation

[Northwind C# Documentation](https://opensource.optivem.com/northwind-csharp)

## Project structure

The following example illustrates the example for suppliers.

### Step 1: Entity

Inside Optivem.Northwind.Core.Domain.Entity, we have:
* Supplier.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Domain.Entity/Supplier.cs"></script>

### Step 2: Repository

Inside the project Optivem.Northwind.Core.Domain.Repository, create the repository interface:
* ISupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Domain.Repository/ISupplierRepository.cs"></script>

Inside the project Optivem.Northwind.Infrastructure.Repository, provide the implementation for that interface:
* SupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Domain.Repository/SupplierRepository.cs"></script>

### Step 3: Unit of Work

Inside the project Optivem.Northwind.Core.Domain.Repository, inside INorthwindUnitOfWork.cs, reference the following:
* ISupplierRepository SupplierRepository { get; }

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Domain.Repository/INorthwindUnitOfWork.cs"></script>

Inside the project Optivem.Northwind.Infrastructure.Repository, inside NorthwindUnitOfWork.cs, reference the following:
* SupplierRepository = new SupplierRepository(context);
* ISupplierRepository SupplierRepository { get; }

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Domain.Repository/NorthwindUnitOfWork.cs"></script>


### Step 4: Service

Inside the project Optivem.Northwind.Core.Application.Service, we have the service interface:
* ISupplierService.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Application.Service/ISupplierService.cs"></script>

Inside the project Optivem.Northwind.Core.Application.Service, we have the service implementation:
* SupplierService

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind.Core.Application.Service/SupplierService.cs"></script>

### Step 5: IoC

Inside the project Optivem.Northwind, inside the class Startup.cs, add the following:
* services.AddScoped<ISupplierService, SupplierService>();

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind/Startup.cs"></script>

### Step 6: Controller

Inside the project Optivem.Northwind, folder Controllers, we have the class (note the plural name):
* SuppliersController

<script src="https://gist-it.appspot.com/github/optivem/northwind-csharp/blob/master/src/Optivem.Northwind/Controllers/SuppliersController.cs"></script>
