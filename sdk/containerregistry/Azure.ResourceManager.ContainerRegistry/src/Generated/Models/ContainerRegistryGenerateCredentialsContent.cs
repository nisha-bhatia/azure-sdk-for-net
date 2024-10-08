// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters used to generate credentials for a specified token or user of a container registry. </summary>
    public partial class ContainerRegistryGenerateCredentialsContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryGenerateCredentialsContent"/>. </summary>
        public ContainerRegistryGenerateCredentialsContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryGenerateCredentialsContent"/>. </summary>
        /// <param name="tokenId"> The resource ID of the token for which credentials have to be generated. </param>
        /// <param name="expireOn"> The expiry date of the generated credentials after which the credentials become invalid. </param>
        /// <param name="name"> Specifies name of the password which should be regenerated if any -- password1 or password2. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryGenerateCredentialsContent(ResourceIdentifier tokenId, DateTimeOffset? expireOn, ContainerRegistryTokenPasswordName? name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TokenId = tokenId;
            ExpireOn = expireOn;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the token for which credentials have to be generated. </summary>
        [WirePath("tokenId")]
        public ResourceIdentifier TokenId { get; set; }
        /// <summary> The expiry date of the generated credentials after which the credentials become invalid. </summary>
        [WirePath("expiry")]
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Specifies name of the password which should be regenerated if any -- password1 or password2. </summary>
        [WirePath("name")]
        public ContainerRegistryTokenPasswordName? Name { get; set; }
    }
}
