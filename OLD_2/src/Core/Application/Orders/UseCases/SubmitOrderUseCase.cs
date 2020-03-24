﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Orders.Requests;
using Optivem.Northwind.Core.Application.Orders.Responses;
using Optivem.Northwind.Core.Domain.Orders.Entities;
using Optivem.Northwind.Core.Domain.Orders.Repositories;
using Optivem.Northwind.Core.Domain.Orders.ValueObjects;

namespace Optivem.Northwind.Core.Application.Orders.UseCases
{
    public class SubmitOrderUseCase : UpdateAggregateUseCase<IOrderRepository, SubmitOrderRequest, SubmitOrderResponse, Order, OrderIdentity, int>
    {
        public SubmitOrderUseCase(IUnitOfWork unitOfWork, IResponseMapper responseMapper) : base(unitOfWork, responseMapper)
        {
        }

        protected override OrderIdentity GetIdentity(int id)
        {
            return new OrderIdentity(id);
        }

        protected override void Update(Order aggregateRoot, SubmitOrderRequest request)
        {
            aggregateRoot.Submit();
        }
    }
}
