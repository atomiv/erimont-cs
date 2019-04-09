# Optivem Northwind (C#)

[![Build Status](https://img.shields.io/appveyor/ci/optivem/northwind-dotnetcore.svg)](https://ci.appveyor.com/project/optivem/northwind-dotnetcore)
[![MIT License](http://img.shields.io/badge/license-MIT-brightgreen.svg)](http://opensource.org/licenses/MIT)

## Documentation

[Northwind C# Documentation](https://opensource.optivem.com/northwind-dotnetcore)

## Issues

[Northwind C# Issues](https://github.com/optivem/northwind-dotnetcore/issues)

## Project structure

The following example illustrates the example for suppliers.

### Entity - Implementation

Inside Optivem.Northwind.Core.Domain.Entity, we have:
* Supplier.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Optivem.Northwind.Core.Domain.Entity/Supplier.cs"></script>

### Repository - Interface

Inside the project Optivem.Northwind.Core.Domain.Repository, create the repository interface:
* ISupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Domain.Repository/ISupplierRepository.cs"></script>

### Repository - Implementation

Inside the project Optivem.Northwind.Infrastructure.Repository, provide the implementation for that interface:
* SupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Infrastructure.Repository/SupplierRepository.cs"></script>

### Unit of Work - Interface

Inside the project Optivem.Northwind.Core.Domain.Repository, inside INorthwindUnitOfWork.cs, reference the following:
* ISupplierRepository SupplierRepository { get; }

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Domain.Repository/INorthwindUnitOfWork.cs"></script>

### Unit of Work - Implementation

Inside the project Optivem.Northwind.Infrastructure.Repository, inside NorthwindUnitOfWork.cs, reference the following:
* SupplierRepository = new SupplierRepository(context);
* ISupplierRepository SupplierRepository { get; }

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Infrastructure.Repository/NorthwindUnitOfWork.cs"></script>

### DTO - Request - Implementation

Inside the project Optivem.Northwind.Core.Application.Dto, we have the class:
* SupplierRequest.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Dto/SupplierRequest.cs"></script>

### DTO - Response - Implementation

Inside the project Optivem.Northwind.Core.Application.Dto, we have the class:
* SupplierResponse.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Dto/SupplierResponse.cs"></script>

### Mapping - Request - Implementation

Inside the project Optivem.Northwind.Core.Application.Mapping, we have the class:
* SupplierRequestMapping

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Mapping/SupplierRequestMapping.cs"></script>

### Mapping - Response - Implementation

Inside the project Optivem.Northwind.Core.Application.Mapping, we have the class:
* SupplierResponseMapping

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Mapping/SupplierResponseMapping.cs"></script>

### Service - Interface

Inside the project Optivem.Northwind.Core.Application.Service, we have the service interface:
* ISupplierService.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Service/ISupplierService.cs"></script>

### Service - Implementation

Inside the project Optivem.Northwind.Core.Application.Service, we have the service implementation:
* SupplierService

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind.Core.Application.Service/SupplierService.cs"></script>

### IoC

Inside the project Optivem.Northwind, inside the class Startup.cs, add the following:
* Registering the service: services.AddScoped<ISupplierService, SupplierService>();
* Adding the mappings for request: e.AddProfile(new SupplierRequestMapping());
* Adding the mappings for request: e.AddProfile(new SupplierResponseMapping());


<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind/Startup.cs"></script>

### Controller

Inside the project Optivem.Northwind, folder Controllers, we have the class (note the plural name):
* SuppliersController

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Optivem.Northwind/Controllers/SuppliersController.cs"></script>

## License

Licensed under the [MIT license](http://opensource.org/licenses/mit-license.php). Copyright © 2018 [Optivem](https://www.optivem.com/) All Rights Reserved. 
