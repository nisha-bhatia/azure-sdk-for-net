// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Azure.Core.Tests.ModelSerializationTests
{
    public class DogListProperty : Animal, IJsonSerializable, IUtf8JsonSerializable
    {
        private Dictionary<string, BinaryData> RawData { get; set; } = new Dictionary<string, BinaryData>();
        public List<string> FoodConsumed { get; set; } = new List<string> {"kibble", "egg"};

        public DogListProperty(string name) : base(default, default, name, default)
        {
            DogName = name;
        }

        internal DogListProperty(string name, Dictionary<string, BinaryData> rawData, List<string> foodConsumed) : this(name)
        {
            RawData = rawData;
            FoodConsumed = foodConsumed;
        }

        private string DogName;

        #region Serialization
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer, SerializableOptions options)
        {
            writer.WriteStartObject();
            if (options.IncludeReadOnlyProperties)
            {
                writer.WritePropertyName("latinName"u8);
                writer.WriteStringValue(LatinName);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(DogName);

            writer.WritePropertyName("foodConsumed"u8);
            writer.WriteStartArray();
            foreach (var item in FoodConsumed)
            {
                writer.WriteStringValue($"{item}");
            }
            writer.WriteEndArray();

            if (options.HandleAdditionalProperties)
            {
                //write out the raw data
                foreach (var property in RawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DogListProperty DeserializeDogListProperty(JsonElement element, SerializableOptions options)
        {
            string name = "";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            List<string> foodConsumed = new List<string>();

            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("foodConsumed"u8))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        foodConsumed.Add(item);
                    }
                    continue;
                }
                if (options.HandleAdditionalProperties)
                {
                    //this means its an unknown property we got
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            return new DogListProperty(name, rawData, foodConsumed);
        }
        #endregion

        #region InterfaceImplementation
        public new bool TryDeserialize(Stream stream, out long bytesConsumed, SerializableOptions options = default)
        {
            bytesConsumed = 0;
            try
            {
                JsonDocument jsonDocument = JsonDocument.Parse(stream);
                var model = DeserializeDogListProperty(jsonDocument.RootElement, options ?? new SerializableOptions());
                this.DogName = model.DogName;
                this.FoodConsumed = model.FoodConsumed;
                this.RawData = model.RawData;
                bytesConsumed = stream.Length;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public new bool TrySerialize(Stream stream, out long bytesWritten, SerializableOptions options = default)
        {
            bytesWritten = 0;
            try
            {
                JsonWriterOptions jsonWriterOptions = new JsonWriterOptions();
                if (options.PrettyPrint)
                {
                    jsonWriterOptions.Indented = true;
                }
                Utf8JsonWriter writer = new Utf8JsonWriter(stream, jsonWriterOptions);
                ((IUtf8JsonSerializable)this).Write(writer, options ?? new SerializableOptions());
                writer.Flush();
                bytesWritten = (int)stream.Length;
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
