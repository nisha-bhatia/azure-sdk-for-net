// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Snowflake linked service. </summary>
    public partial class SnowflakeV2LinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SnowflakeV2LinkedService"/>. </summary>
        /// <param name="accountIdentifier"> The account identifier of your Snowflake account, e.g. xy12345.east-us-2.azure. </param>
        /// <param name="database"> The name of the Snowflake database. </param>
        /// <param name="warehouse"> The name of the Snowflake warehouse. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountIdentifier"/>, <paramref name="database"/> or <paramref name="warehouse"/> is null. </exception>
        public SnowflakeV2LinkedService(DataFactoryElement<string> accountIdentifier, DataFactoryElement<string> database, DataFactoryElement<string> warehouse)
        {
            Argument.AssertNotNull(accountIdentifier, nameof(accountIdentifier));
            Argument.AssertNotNull(database, nameof(database));
            Argument.AssertNotNull(warehouse, nameof(warehouse));

            AccountIdentifier = accountIdentifier;
            Database = database;
            Warehouse = warehouse;
            LinkedServiceType = "SnowflakeV2";
        }

        /// <summary> Initializes a new instance of <see cref="SnowflakeV2LinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="accountIdentifier"> The account identifier of your Snowflake account, e.g. xy12345.east-us-2.azure. </param>
        /// <param name="user"> The name of the Snowflake user. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. </param>
        /// <param name="database"> The name of the Snowflake database. </param>
        /// <param name="warehouse"> The name of the Snowflake warehouse. </param>
        /// <param name="authenticationType"> The type used for authentication. Type: string. </param>
        /// <param name="clientId"> The client ID of the application registered in Azure Active Directory for AADServicePrincipal authentication. </param>
        /// <param name="clientSecret"> The Azure key vault secret reference of client secret for AADServicePrincipal authentication. </param>
        /// <param name="tenantId"> The tenant ID of the application registered in Azure Active Directory for AADServicePrincipal authentication. </param>
        /// <param name="scope"> The scope of the application registered in Azure Active Directory for AADServicePrincipal authentication. </param>
        /// <param name="privateKey"> The Azure key vault secret reference of privateKey for KeyPair auth. </param>
        /// <param name="privateKeyPassphrase"> The Azure key vault secret reference of private key password for KeyPair auth with encrypted private key. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SnowflakeV2LinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> accountIdentifier, DataFactoryElement<string> user, DataFactorySecret password, DataFactoryElement<string> database, DataFactoryElement<string> warehouse, SnowflakeAuthenticationType? authenticationType, DataFactoryElement<string> clientId, DataFactorySecret clientSecret, DataFactoryElement<string> tenantId, DataFactoryElement<string> scope, DataFactorySecret privateKey, DataFactorySecret privateKeyPassphrase, string encryptedCredential) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            AccountIdentifier = accountIdentifier;
            User = user;
            Password = password;
            Database = database;
            Warehouse = warehouse;
            AuthenticationType = authenticationType;
            ClientId = clientId;
            ClientSecret = clientSecret;
            TenantId = tenantId;
            Scope = scope;
            PrivateKey = privateKey;
            PrivateKeyPassphrase = privateKeyPassphrase;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SnowflakeV2";
        }

        /// <summary> Initializes a new instance of <see cref="SnowflakeV2LinkedService"/> for deserialization. </summary>
        internal SnowflakeV2LinkedService()
        {
        }

        /// <summary> The account identifier of your Snowflake account, e.g. xy12345.east-us-2.azure. </summary>
        public DataFactoryElement<string> AccountIdentifier { get; set; }
        /// <summary> The name of the Snowflake user. </summary>
        public DataFactoryElement<string> User { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The name of the Snowflake database. </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> The name of the Snowflake warehouse. </summary>
        public DataFactoryElement<string> Warehouse { get; set; }
        /// <summary> The type used for authentication. Type: string. </summary>
        public SnowflakeAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The client ID of the application registered in Azure Active Directory for AADServicePrincipal authentication. </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The Azure key vault secret reference of client secret for AADServicePrincipal authentication. </summary>
        public DataFactorySecret ClientSecret { get; set; }
        /// <summary> The tenant ID of the application registered in Azure Active Directory for AADServicePrincipal authentication. </summary>
        public DataFactoryElement<string> TenantId { get; set; }
        /// <summary> The scope of the application registered in Azure Active Directory for AADServicePrincipal authentication. </summary>
        public DataFactoryElement<string> Scope { get; set; }
        /// <summary> The Azure key vault secret reference of privateKey for KeyPair auth. </summary>
        public DataFactorySecret PrivateKey { get; set; }
        /// <summary> The Azure key vault secret reference of private key password for KeyPair auth with encrypted private key. </summary>
        public DataFactorySecret PrivateKeyPassphrase { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
