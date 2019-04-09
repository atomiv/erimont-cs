## Project structure

The following example illustrates the example for suppliers.

## Core

### Domain

Entities are implemented in the project Optivem.Northwind.Core.Domain.Entity. For example, we have the Supplier entity:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Entity/Supplier.cs"></script>

Interfaces for repositories are declared in the project Optivem.Northwind.Core.Domain.Repository. For example, we have ISupplierRepository, which is the repository interface for working with suppliers:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Repository/ISupplierRepository.cs"></script>

Aside from adding the repository in Optivem.Northwind.Core.Domain.Repository, we also register it in the unit of work INorthwindUnitOfWork. For example, we register ISupplierRepository as a property below:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Domain/Repository/INorthwindUnitOfWork.cs"></script>

### Application

Dtos are referenced in the project Optivem.Northwind.Core.Application.Dto. For example, we have the SupplierRequest:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Dto/SupplierRequest.cs"></script>

In that same project, we also have the SupplierResponse:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Dto/SupplierResponse.cs"></script>

We declare the interfaces for services in the project Optivem.Northwind.Core.Application.Service. For example, we have the interface ISupplierService:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Service/ISupplierService.cs"></script>

Then we need to implement the services in the project Optivem.Northwind.Core.Application.Service.Default. For example, we have implemented SupplierService:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Core/Application/Service.Default/SupplierService.cs"></script>

### Infrastructure

We implement repositories using the EntityFrameworkCore implementation in the project Optivem.Northwind.Infrastructure.Repository.EntityFrameworkCore (note: we could have used other providers). For example, we have implemented SupplierRepository:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Domain/Repository.EntityFrameworkCore/SupplierRepository.cs"></script>

Inside that same project, we also add the repository SupplierRepository to the unit of work class NorthwindUnitOfWork:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Domain/Repository.EntityFrameworkCore/NorthwindUnitOfWork.cs"></script>

We also implement request mapping using AutoMapper in the project Optivem.Northwind.Infrastructure.Application.Mapping. For example, we have implemented SupplierRequestMapping:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Application/Mapping.AutoMapper/SupplierRequestMapping.cs"></script>

Furthermore, inside that same project we also implement the response mapping. For example, we have implemented SupplierResponseMapping:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Infrastructure/Application/Mapping.AutoMapper/SupplierResponseMapping.cs"></script>

### Web

Inside the project Optivem.Northwind.Web.AspNetCore.Rest, we register the services and the mappings inside Startup. For example, we have registered SupplierService, SupplierRequestMapping and SupplierResponseMapping:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Web/AspNetCore/Rest/Startup.cs"></script>

Furthermore, in that project, inside the folder Controllers we also need to implement the controllers. For example, we have implemented SuppliersController:

<script src="https://gist-it.appspot.com/github/optivem/northwind-dotnetcore/blob/master/src/Web/AspNetCore/Rest/Controllers/SuppliersController.cs"></script>


### Test

Pending documentation.