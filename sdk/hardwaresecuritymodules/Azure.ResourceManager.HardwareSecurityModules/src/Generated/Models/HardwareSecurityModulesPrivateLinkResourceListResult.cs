// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class HardwareSecurityModulesPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of HardwareSecurityModulesPrivateLinkResourceListResult. </summary>
        internal HardwareSecurityModulesPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<HardwareSecurityModulesPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of HardwareSecurityModulesPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal HardwareSecurityModulesPrivateLinkResourceListResult(IReadOnlyList<HardwareSecurityModulesPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<HardwareSecurityModulesPrivateLinkResource> Value { get; }
    }
}
