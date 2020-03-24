﻿using Optivem.Atomiv.Core.Common.Http;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.AspNetCore;
using Erimont.Core.Application.Customers.Commands;
using Erimont.Core.Application.Customers.Queries;
using Erimont.Web.RestClient.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Erimont.Web.RestClient
{
    public class CustomerControllerClient : ICustomerControllerClient
    {
        private readonly JsonHttpControllerClient _controllerClient;

        public CustomerControllerClient(HttpClient httpClient, IJsonSerializer jsonSerializer)
        {
            _controllerClient = new JsonHttpControllerClient(httpClient, jsonSerializer, "api/customers");
        }

        #region Commands

        public Task<IObjectClientResponse<CreateCustomerCommandResponse>> CreateCustomerAsync(CreateCustomerCommand request)
        {
            return _controllerClient.PostAsync<CreateCustomerCommand, CreateCustomerCommandResponse>(request);
        }

        public Task<IObjectClientResponse<DeleteCustomerCommandResponse>> DeleteCustomerAsync(DeleteCustomerCommand request)
        {
            var id = request.Id;
            return _controllerClient.DeleteByIdAsync<Guid, DeleteCustomerCommandResponse>(id);
        }

        public Task<IObjectClientResponse<EditCustomerCommandResponse>> EditCustomerAsync(EditCustomerCommand request)
        {
            return _controllerClient.PutByIdAsync<Guid, EditCustomerCommand, EditCustomerCommandResponse>(request.Id, request);
        }

        #endregion

        #region Queries

        public Task<IObjectClientResponse<BrowseCustomersQueryResponse>> BrowseCustomersAsync(BrowseCustomersQuery request)
        {
            return _controllerClient.GetAsync<BrowseCustomersQuery, BrowseCustomersQueryResponse>(request);
        }

        public Task<IObjectClientResponse<FilterCustomersQueryResponse>> FilterCustomersAsync(FilterCustomersQuery request)
        {
            return _controllerClient.GetAsync<FilterCustomersQuery, FilterCustomersQueryResponse>("filter", request);
        }

        public Task<IObjectClientResponse<ViewCustomerQueryResponse>> ViewCustomerAsync(ViewCustomerQuery request)
        {
            var id = request.Id;
            return _controllerClient.GetByIdAsync<Guid, ViewCustomerQueryResponse>(id);
        }

        #endregion
    }
}