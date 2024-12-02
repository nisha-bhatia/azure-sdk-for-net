// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> Concrete tracked resource types can be created by aliasing this type using a specific property type. </summary>
    public partial class Foo : TrackedResource
    {
        /// <summary> Initializes a new instance of <see cref="Foo"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Foo(string location) : base(location)
        {
            Argument.AssertNotNull(location, nameof(location));

        }

        internal Foo(ResourceIdentifier id, string name, string @type, SystemData systemData, IDictionary<string, BinaryData> additionalBinaryDataProperties, IDictionary<string, string> tags, string location, FooProperties properties, ExtendedLocation extendedLocation) : base(id, name, @type, systemData, additionalBinaryDataProperties, tags, location)
        {
            Properties = properties;
            ExtendedLocation = extendedLocation;
        }

        /// <summary> The resource-specific properties for this resource. </summary>
        public FooProperties Properties { get; set; }

        /// <summary> Gets or sets the ExtendedLocation. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
    }
}
