// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The comma separated list of resource IDs to query metrics for. </summary>
    public partial class ResourceIdList
    {
        /// <summary> Initializes a new instance of ResourceIdList. </summary>
        public ResourceIdList()
        {
            Resourceids = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> The list of resource IDs to query metrics for. </summary>
        public IList<ResourceIdentifier> Resourceids { get; }
    }
}
