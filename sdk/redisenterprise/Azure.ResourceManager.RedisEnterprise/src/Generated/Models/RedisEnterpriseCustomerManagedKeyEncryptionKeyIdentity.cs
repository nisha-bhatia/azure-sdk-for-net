// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
    public partial class RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity
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

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity"/>. </summary>
        public RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity"/>. </summary>
        /// <param name="userAssignedIdentityResourceId"> User assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/&lt;sub uuid&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </param>
        /// <param name="identityType"> Only userAssignedIdentity is supported in this API version; other types may be supported in the future. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(ResourceIdentifier userAssignedIdentityResourceId, RedisEnterpriseCustomerManagedKeyIdentityType? identityType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserAssignedIdentityResourceId = userAssignedIdentityResourceId;
            IdentityType = identityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> User assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/&lt;sub uuid&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </summary>
        [WirePath("userAssignedIdentityResourceId")]
        public ResourceIdentifier UserAssignedIdentityResourceId { get; set; }
        /// <summary> Only userAssignedIdentity is supported in this API version; other types may be supported in the future. </summary>
        [WirePath("identityType")]
        public RedisEnterpriseCustomerManagedKeyIdentityType? IdentityType { get; set; }
    }
}
