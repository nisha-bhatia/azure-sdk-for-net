// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(MetastoreUpdateObjectConverter))]
    public partial class MetastoreUpdateObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("inputFolder");
            writer.WriteStringValue(InputFolder);
            writer.WriteEndObject();
        }

        internal partial class MetastoreUpdateObjectConverter : JsonConverter<MetastoreUpdateObject>
        {
            public override void Write(Utf8JsonWriter writer, MetastoreUpdateObject model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MetastoreUpdateObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
