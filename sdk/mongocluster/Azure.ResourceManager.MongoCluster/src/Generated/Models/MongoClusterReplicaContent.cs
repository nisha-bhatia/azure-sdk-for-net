// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> Parameters used for replica operations. </summary>
    public partial class MongoClusterReplicaContent
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

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicaContent"/>. </summary>
        /// <param name="sourceResourceId"> The id of the replication source cluster. </param>
        /// <param name="sourceLocation"> The location of the source cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceResourceId"/> is null. </exception>
        public MongoClusterReplicaContent(ResourceIdentifier sourceResourceId, AzureLocation sourceLocation)
        {
            Argument.AssertNotNull(sourceResourceId, nameof(sourceResourceId));

            SourceResourceId = sourceResourceId;
            SourceLocation = sourceLocation;
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicaContent"/>. </summary>
        /// <param name="sourceResourceId"> The id of the replication source cluster. </param>
        /// <param name="sourceLocation"> The location of the source cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoClusterReplicaContent(ResourceIdentifier sourceResourceId, AzureLocation sourceLocation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceResourceId = sourceResourceId;
            SourceLocation = sourceLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicaContent"/> for deserialization. </summary>
        internal MongoClusterReplicaContent()
        {
        }

        /// <summary> The id of the replication source cluster. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> The location of the source cluster. </summary>
        public AzureLocation SourceLocation { get; set; }
    }
}
