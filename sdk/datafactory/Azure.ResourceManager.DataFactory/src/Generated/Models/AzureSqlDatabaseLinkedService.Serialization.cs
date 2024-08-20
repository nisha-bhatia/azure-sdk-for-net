// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureSqlDatabaseLinkedService : IUtf8JsonSerializable, IJsonModel<AzureSqlDatabaseLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureSqlDatabaseLinkedService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureSqlDatabaseLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSqlDatabaseLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSqlDatabaseLinkedService)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(LinkedServiceVersion))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(LinkedServiceVersion);
            }
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                JsonSerializer.Serialize(writer, Server);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                JsonSerializer.Serialize(writer, Database);
            }
            if (Optional.IsDefined(Encrypt))
            {
                writer.WritePropertyName("encrypt"u8);
                JsonSerializer.Serialize(writer, Encrypt);
            }
            if (Optional.IsDefined(TrustServerCertificate))
            {
                writer.WritePropertyName("trustServerCertificate"u8);
                JsonSerializer.Serialize(writer, TrustServerCertificate);
            }
            if (Optional.IsDefined(HostNameInCertificate))
            {
                writer.WritePropertyName("hostNameInCertificate"u8);
                JsonSerializer.Serialize(writer, HostNameInCertificate);
            }
            if (Optional.IsDefined(ApplicationIntent))
            {
                writer.WritePropertyName("applicationIntent"u8);
                JsonSerializer.Serialize(writer, ApplicationIntent);
            }
            if (Optional.IsDefined(ConnectTimeout))
            {
                writer.WritePropertyName("connectTimeout"u8);
                JsonSerializer.Serialize(writer, ConnectTimeout);
            }
            if (Optional.IsDefined(ConnectRetryCount))
            {
                writer.WritePropertyName("connectRetryCount"u8);
                JsonSerializer.Serialize(writer, ConnectRetryCount);
            }
            if (Optional.IsDefined(ConnectRetryInterval))
            {
                writer.WritePropertyName("connectRetryInterval"u8);
                JsonSerializer.Serialize(writer, ConnectRetryInterval);
            }
            if (Optional.IsDefined(LoadBalanceTimeout))
            {
                writer.WritePropertyName("loadBalanceTimeout"u8);
                JsonSerializer.Serialize(writer, LoadBalanceTimeout);
            }
            if (Optional.IsDefined(CommandTimeout))
            {
                writer.WritePropertyName("commandTimeout"u8);
                JsonSerializer.Serialize(writer, CommandTimeout);
            }
            if (Optional.IsDefined(IntegratedSecurity))
            {
                writer.WritePropertyName("integratedSecurity"u8);
                JsonSerializer.Serialize(writer, IntegratedSecurity);
            }
            if (Optional.IsDefined(FailoverPartner))
            {
                writer.WritePropertyName("failoverPartner"u8);
                JsonSerializer.Serialize(writer, FailoverPartner);
            }
            if (Optional.IsDefined(MaxPoolSize))
            {
                writer.WritePropertyName("maxPoolSize"u8);
                JsonSerializer.Serialize(writer, MaxPoolSize);
            }
            if (Optional.IsDefined(MinPoolSize))
            {
                writer.WritePropertyName("minPoolSize"u8);
                JsonSerializer.Serialize(writer, MinPoolSize);
            }
            if (Optional.IsDefined(MultipleActiveResultSets))
            {
                writer.WritePropertyName("multipleActiveResultSets"u8);
                JsonSerializer.Serialize(writer, MultipleActiveResultSets);
            }
            if (Optional.IsDefined(MultiSubnetFailover))
            {
                writer.WritePropertyName("multiSubnetFailover"u8);
                JsonSerializer.Serialize(writer, MultiSubnetFailover);
            }
            if (Optional.IsDefined(PacketSize))
            {
                writer.WritePropertyName("packetSize"u8);
                JsonSerializer.Serialize(writer, PacketSize);
            }
            if (Optional.IsDefined(Pooling))
            {
                writer.WritePropertyName("pooling"u8);
                JsonSerializer.Serialize(writer, Pooling);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                JsonSerializer.Serialize(writer, ConnectionString);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                JsonSerializer.Serialize(writer, UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                JsonSerializer.Serialize(writer, Password);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Optional.IsDefined(ServicePrincipalCredentialType))
            {
                writer.WritePropertyName("servicePrincipalCredentialType"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalCredentialType);
            }
            if (Optional.IsDefined(ServicePrincipalCredential))
            {
                writer.WritePropertyName("servicePrincipalCredential"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalCredential);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                JsonSerializer.Serialize(writer, Tenant);
            }
            if (Optional.IsDefined(AzureCloudType))
            {
                writer.WritePropertyName("azureCloudType"u8);
                JsonSerializer.Serialize(writer, AzureCloudType);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Optional.IsDefined(AlwaysEncryptedSettings))
            {
                writer.WritePropertyName("alwaysEncryptedSettings"u8);
                writer.WriteObjectValue(AlwaysEncryptedSettings, options);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential, options);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        AzureSqlDatabaseLinkedService IJsonModel<AzureSqlDatabaseLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSqlDatabaseLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSqlDatabaseLinkedService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSqlDatabaseLinkedService(document.RootElement, options);
        }

        internal static AzureSqlDatabaseLinkedService DeserializeAzureSqlDatabaseLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string version = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<string> server = default;
            DataFactoryElement<string> database = default;
            DataFactoryElement<string> encrypt = default;
            DataFactoryElement<bool> trustServerCertificate = default;
            DataFactoryElement<string> hostNameInCertificate = default;
            DataFactoryElement<string> applicationIntent = default;
            DataFactoryElement<int> connectTimeout = default;
            DataFactoryElement<int> connectRetryCount = default;
            DataFactoryElement<int> connectRetryInterval = default;
            DataFactoryElement<int> loadBalanceTimeout = default;
            DataFactoryElement<int> commandTimeout = default;
            DataFactoryElement<bool> integratedSecurity = default;
            DataFactoryElement<string> failoverPartner = default;
            DataFactoryElement<int> maxPoolSize = default;
            DataFactoryElement<int> minPoolSize = default;
            DataFactoryElement<bool> multipleActiveResultSets = default;
            DataFactoryElement<bool> multiSubnetFailover = default;
            DataFactoryElement<int> packetSize = default;
            DataFactoryElement<bool> pooling = default;
            DataFactoryElement<string> connectionString = default;
            AzureSqlDatabaseAuthenticationType? authenticationType = default;
            DataFactoryElement<string> userName = default;
            DataFactoryKeyVaultSecret password = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecret servicePrincipalKey = default;
            DataFactoryElement<string> servicePrincipalCredentialType = default;
            DataFactorySecret servicePrincipalCredential = default;
            DataFactoryElement<string> tenant = default;
            DataFactoryElement<string> azureCloudType = default;
            string encryptedCredential = default;
            SqlAlwaysEncryptedProperties alwaysEncryptedSettings = default;
            DataFactoryCredentialReference credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            server = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            database = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encrypt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encrypt = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trustServerCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustServerCertificate = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostNameInCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostNameInCertificate = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("applicationIntent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationIntent = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectTimeout = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectRetryCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectRetryInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectRetryInterval = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loadBalanceTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalanceTimeout = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("commandTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commandTimeout = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("integratedSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            integratedSecurity = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("failoverPartner"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverPartner = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("maxPoolSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxPoolSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("minPoolSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minPoolSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("multipleActiveResultSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multipleActiveResultSets = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("multiSubnetFailover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multiSubnetFailover = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("packetSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packetSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("pooling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pooling = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectionString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionString = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationType = new AzureSqlDatabaseAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = JsonSerializer.Deserialize<DataFactoryKeyVaultSecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredentialType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredentialType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredential = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenant = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCloudType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alwaysEncryptedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alwaysEncryptedSettings = SqlAlwaysEncryptedProperties.DeserializeSqlAlwaysEncryptedProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureSqlDatabaseLinkedService(
                type,
                version,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                server,
                database,
                encrypt,
                trustServerCertificate,
                hostNameInCertificate,
                applicationIntent,
                connectTimeout,
                connectRetryCount,
                connectRetryInterval,
                loadBalanceTimeout,
                commandTimeout,
                integratedSecurity,
                failoverPartner,
                maxPoolSize,
                minPoolSize,
                multipleActiveResultSets,
                multiSubnetFailover,
                packetSize,
                pooling,
                connectionString,
                authenticationType,
                userName,
                password,
                servicePrincipalId,
                servicePrincipalKey,
                servicePrincipalCredentialType,
                servicePrincipalCredential,
                tenant,
                azureCloudType,
                encryptedCredential,
                alwaysEncryptedSettings,
                credential);
        }

        BinaryData IPersistableModel<AzureSqlDatabaseLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSqlDatabaseLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureSqlDatabaseLinkedService)} does not support writing '{options.Format}' format.");
            }
        }

        AzureSqlDatabaseLinkedService IPersistableModel<AzureSqlDatabaseLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSqlDatabaseLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureSqlDatabaseLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureSqlDatabaseLinkedService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureSqlDatabaseLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
