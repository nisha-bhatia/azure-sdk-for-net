// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary>
    /// todo
    /// </summary>
    public partial class MetricsBatchResult
    {
        /// <summary>
        /// todo
        /// </summary>
        public List<MetricsQueryResult> MetricsQueryResult { get; set; } = new List<MetricsQueryResult>();
    }
}
