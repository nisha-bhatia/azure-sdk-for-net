// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The parameters to the list SAS request. </summary>
    public partial class MediaAssetStorageContainerSasContent
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

        /// <summary> Initializes a new instance of <see cref="MediaAssetStorageContainerSasContent"/>. </summary>
        public MediaAssetStorageContainerSasContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaAssetStorageContainerSasContent"/>. </summary>
        /// <param name="permissions"> The permissions to set on the SAS URL. </param>
        /// <param name="expireOn"> The SAS URL expiration time.  This must be less than 24 hours from the current time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaAssetStorageContainerSasContent(MediaAssetContainerPermission? permissions, DateTimeOffset? expireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Permissions = permissions;
            ExpireOn = expireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The permissions to set on the SAS URL. </summary>
        public MediaAssetContainerPermission? Permissions { get; set; }
        /// <summary> The SAS URL expiration time.  This must be less than 24 hours from the current time. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
