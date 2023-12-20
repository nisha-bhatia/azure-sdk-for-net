// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    internal partial class ErrorResponseAutoGenerated3
    {
        internal static ErrorResponseAutoGenerated3 DeserializeErrorResponseAutoGenerated3(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ErrorDetailAutoGenerated> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorDetailAutoGenerated.DeserializeErrorDetailAutoGenerated(property.Value);
                    continue;
                }
            }
            return new ErrorResponseAutoGenerated3(error.Value);
        }
    }
}
