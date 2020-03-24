﻿using System;
using System.Collections.Generic;

namespace Erimont.Core.Application.Products.Queries
{
    public class BrowseProductsQueryResponse
    {
        public List<BrowseProductsRecordResponse> Records { get; set; }

        public long TotalRecords { get; set; }
    }

    public class BrowseProductsRecordResponse
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsListed { get; set; }
    }
}