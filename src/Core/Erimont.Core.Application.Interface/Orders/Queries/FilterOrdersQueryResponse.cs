﻿using System;
using System.Collections.Generic;

namespace Erimont.Core.Application.Orders.Queries
{
    public class FilterOrdersQueryResponse
    {
        public List<ListOrdersRecordQueryResponse> Records { get; set; }

        public long TotalRecords { get; set; }
    }

    public class ListOrdersRecordQueryResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}