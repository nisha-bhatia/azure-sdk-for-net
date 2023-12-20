// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Represents collection of metric definitions. </summary>
    internal partial class MetricDefinitionCollection
    {
        /// <summary> Initializes a new instance of <see cref="MetricDefinitionCollection"/>. </summary>
        /// <param name="value"> The values for the metric definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal MetricDefinitionCollection(IEnumerable<MetricDefinition> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MetricDefinitionCollection"/>. </summary>
        /// <param name="value"> The values for the metric definitions. </param>
        internal MetricDefinitionCollection(IReadOnlyList<MetricDefinition> value)
        {
            Value = value;
        }

        /// <summary> The values for the metric definitions. </summary>
        public IReadOnlyList<MetricDefinition> Value { get; }
    }
}
