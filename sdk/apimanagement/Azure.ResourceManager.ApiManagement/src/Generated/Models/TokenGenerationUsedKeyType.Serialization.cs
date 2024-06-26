// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class TokenGenerationUsedKeyTypeExtensions
    {
        public static string ToSerialString(this TokenGenerationUsedKeyType value) => value switch
        {
            TokenGenerationUsedKeyType.Primary => "primary",
            TokenGenerationUsedKeyType.Secondary => "secondary",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenGenerationUsedKeyType value.")
        };

        public static TokenGenerationUsedKeyType ToTokenGenerationUsedKeyType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "primary")) return TokenGenerationUsedKeyType.Primary;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "secondary")) return TokenGenerationUsedKeyType.Secondary;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenGenerationUsedKeyType value.");
        }
    }
}
