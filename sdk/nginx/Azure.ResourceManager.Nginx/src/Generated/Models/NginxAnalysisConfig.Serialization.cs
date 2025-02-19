// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxAnalysisConfig : IUtf8JsonSerializable, IJsonModel<NginxAnalysisConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxAnalysisConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NginxAnalysisConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxAnalysisConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RootFile))
            {
                writer.WritePropertyName("rootFile"u8);
                writer.WriteStringValue(RootFile);
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProtectedFiles))
            {
                writer.WritePropertyName("protectedFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedFiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Package))
            {
                writer.WritePropertyName("package"u8);
                writer.WriteObjectValue(Package, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
        }

        NginxAnalysisConfig IJsonModel<NginxAnalysisConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxAnalysisConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxAnalysisConfig(document.RootElement, options);
        }

        internal static NginxAnalysisConfig DeserializeNginxAnalysisConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rootFile = default;
            IList<NginxConfigurationFile> files = default;
            IList<NginxConfigurationProtectedFileContent> protectedFiles = default;
            NginxConfigurationPackage package = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rootFile"u8))
                {
                    rootFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationFile> array = new List<NginxConfigurationFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationFile.DeserializeNginxConfigurationFile(item, options));
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("protectedFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationProtectedFileContent> array = new List<NginxConfigurationProtectedFileContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationProtectedFileContent.DeserializeNginxConfigurationProtectedFileContent(item, options));
                    }
                    protectedFiles = array;
                    continue;
                }
                if (property.NameEquals("package"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    package = NginxConfigurationPackage.DeserializeNginxConfigurationPackage(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NginxAnalysisConfig(rootFile, files ?? new ChangeTrackingList<NginxConfigurationFile>(), protectedFiles ?? new ChangeTrackingList<NginxConfigurationProtectedFileContent>(), package, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxAnalysisConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxAnalysisConfig)} does not support writing '{options.Format}' format.");
            }
        }

        NginxAnalysisConfig IPersistableModel<NginxAnalysisConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxAnalysisConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxAnalysisConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxAnalysisConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxAnalysisConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
