// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationInnerHealthErrorInfo
    {
        internal static DataReplicationInnerHealthErrorInfo DeserializeDataReplicationInnerHealthErrorInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> healthCategory = default;
            Optional<string> category = default;
            Optional<string> severity = default;
            Optional<string> source = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<bool> isCustomerResolvable = default;
            Optional<string> summary = default;
            Optional<string> message = default;
            Optional<string> causes = default;
            Optional<string> recommendation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCategory"u8))
                {
                    healthCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isCustomerResolvable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCustomerResolvable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("causes"u8))
                {
                    causes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendation"u8))
                {
                    recommendation = property.Value.GetString();
                    continue;
                }
            }
            return new DataReplicationInnerHealthErrorInfo(code.Value, healthCategory.Value, category.Value, severity.Value, source.Value, Optional.ToNullable(creationTime), Optional.ToNullable(isCustomerResolvable), summary.Value, message.Value, causes.Value, recommendation.Value);
        }
    }
}
