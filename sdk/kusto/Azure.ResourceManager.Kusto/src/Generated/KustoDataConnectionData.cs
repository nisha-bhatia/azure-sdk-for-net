// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing the KustoDataConnection data model.
    /// Class representing an data connection.
    /// Please note <see cref="KustoDataConnectionData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="KustoCosmosDBDataConnection"/>, <see cref="KustoEventGridDataConnection"/>, <see cref="KustoEventHubDataConnection"/> and <see cref="KustoIotHubDataConnection"/>.
    /// </summary>
    public partial class KustoDataConnectionData : ResourceData
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoDataConnectionData"/>. </summary>
        public KustoDataConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KustoDataConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoDataConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Kind of the endpoint for the data connection. </summary>
        internal DataConnectionKind Kind { get; set; }
    }
}
