// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ModelSerializationTests
{
    public class DynamicDataMiniModel : IModelSerializable, IUtf8JsonSerializable, IJsonModelSerializable
    {
        public DynamicDataMiniModel(string x)
        {
            X = x;
        }

        internal DynamicDataMiniModel()
        {
        }

        public string X { get; set; }

        #region Serialization
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModelSerializable)this).Serialize(writer, ModelSerializerOptions.AzureServiceDefault);

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("foo"u8);
            writer.WriteStringValue(X);

            writer.WriteEndObject();
        }

        internal static DynamicDataMiniModel DeserializeDynamicDataMiniModel(JsonElement element, ModelSerializerOptions options)
        {
            string x = "";

            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foo"u8))
                {
                    x = property.Value.GetString();
                    continue;
                }
            }
            return new DynamicDataMiniModel(x);
        }

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            return DeserializeDynamicDataMiniModel(JsonDocument.Parse(data.ToString()).RootElement, options);
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            JsonDocument doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynamicDataMiniModel(doc.RootElement, options);
        }
        #endregion
    }
}
