// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    /// <summary> Client options for TextAnalysisClient. </summary>
    public partial class TextAnalysisClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_11_15_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-05-01". </summary>
            V2022_05_01 = 1,
            /// <summary> Service version "2023-04-01". </summary>
            V2023_04_01 = 2,
            /// <summary> Service version "2023-11-15-preview". </summary>
            V2023_11_15_Preview = 3,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of TextAnalysisClientOptions. </summary>
        public TextAnalysisClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_05_01 => "2022-05-01",
                ServiceVersion.V2023_04_01 => "2023-04-01",
                ServiceVersion.V2023_11_15_Preview => "2023-11-15-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
