// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Gateway details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GatewayContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayContract class.
        /// </summary>
        public GatewayContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="locationData">Gateway location.</param>
        /// <param name="description">Gateway description</param>
        public GatewayContract(string id = default(string), string name = default(string), string type = default(string), ResourceLocationDataContract locationData = default(ResourceLocationDataContract), string description = default(string))
            : base(id, name, type)
        {
            LocationData = locationData;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gateway location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locationData")]
        public ResourceLocationDataContract LocationData { get; set; }

        /// <summary>
        /// Gets or sets gateway description
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LocationData != null)
            {
                LocationData.Validate();
            }
            if (Description != null)
            {
                if (Description.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1000);
                }
            }
        }
    }
}
