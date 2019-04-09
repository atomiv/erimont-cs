## Project structure

The following example illustrates the example for suppliers.

## Core

### Domain

Inside Optivem.Northwind.Core.Domain.Entity, we have:
* Supplier.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Entity/Supplier.cs"></script>

Inside the project Optivem.Northwind.Core.Domain.Repository, create the repository interface:
* ISupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Repository/ISupplierRepository.cs"></script>

Inside the project Optivem.Northwind.Core.Domain.Repository, inside INorthwindUnitOfWork.cs, reference the following:
* ISupplierRepository SupplierRepository { get; }

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Repository/INorthwindUnitOfWork.cs"></script>

### Application

Inside the project Optivem.Northwind.Core.Application.Dto, we have the class:
* SupplierRequest.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Dto/SupplierRequest.cs"></script>

Inside the project Optivem.Northwind.Core.Application.Dto, we have the class:
* SupplierResponse.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Dto/SupplierResponse.cs"></script>

Inside the project Optivem.Northwind.Core.Application.Service, we have the service interface:
* ISupplierService.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Service/ISupplierService.cs"></script>

Inside the project Optivem.Northwind.Core.Application.Service.Default, we have the service implementation:
* SupplierService

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Service.Default/SupplierService.cs"></script>

### Infrastructure

Inside the project Optivem.Northwind.Infrastructure.Repository, provide the implementation for that interface:
* SupplierRepository.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Domain/Repository/SupplierRepository.cs"></script>

Inside the project Optivem.Northwind.Infrastructure.Repository, we reference the SupplierRepository in the following class:
* NorthwindUnitOfWork.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Domain/Repository/NorthwindUnitOfWork.cs"></script>

Inside the project Optivem.Northwind.Core.Application.Mapping, we have the class:
* SupplierRequestMapping

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Mapping.AutoMapper/SupplierRequestMapping.cs"></script>


Inside the project Optivem.Northwind.Core.Application.Mapping, we have the class:
* SupplierResponseMapping

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Mapping.AutomMapper/SupplierResponseMapping.cs"></script>

### Web


Inside the project Optivem.Northwind.Web.AspNetCore.Rest, we register SupplierService, SupplierRequestMapping and SupplierResponseMapping inside the following class:
* Startup.cs

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Web/AspNetCore/Rest/Startup.cs"></script>

### Controller

Inside the project Optivem.Northwind.Web.AspNetCore.Rest, folder Controllers, we have the class (note the plural name):
* SuppliersController

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Web/AspNetCore/Rest/Controllers/SuppliersController.cs"></script>


### Test

Pending documentation.