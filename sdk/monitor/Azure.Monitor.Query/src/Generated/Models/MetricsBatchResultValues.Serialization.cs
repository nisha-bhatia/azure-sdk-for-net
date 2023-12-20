// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricsBatchResultValues
    {
        internal static MetricsBatchResultValues DeserializeMetricsBatchResultValues(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset starttime = default;
            DateTimeOffset endtime = default;
            Optional<string> interval = default;
            Optional<string> @namespace = default;
            Optional<AzureLocation> resourceregion = default;
            Optional<ResourceIdentifier> resourceid = default;
            IReadOnlyList<MetricResult> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("starttime"u8))
                {
                    starttime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("endtime"u8))
                {
                    endtime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    interval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceregion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<MetricResult> array = new List<MetricResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricResult.DeserializeMetricResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricsBatchResultValues(starttime, endtime, interval.Value, @namespace.Value, resourceregion, resourceid.Value, value);
        }
    }
}
