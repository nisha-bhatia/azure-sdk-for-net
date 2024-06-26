// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The resource limits. </summary>
    public partial class ContainerResourceLimits
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

        /// <summary> Initializes a new instance of <see cref="ContainerResourceLimits"/>. </summary>
        public ContainerResourceLimits()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerResourceLimits"/>. </summary>
        /// <param name="memoryInGB"> The memory limit in GB of this container instance. </param>
        /// <param name="cpu"> The CPU limit of this container instance. </param>
        /// <param name="gpu"> The GPU limit of this container instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerResourceLimits(double? memoryInGB, double? cpu, ContainerGpuResourceInfo gpu, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            Gpu = gpu;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The memory limit in GB of this container instance. </summary>
        public double? MemoryInGB { get; set; }
        /// <summary> The CPU limit of this container instance. </summary>
        public double? Cpu { get; set; }
        /// <summary> The GPU limit of this container instance. </summary>
        public ContainerGpuResourceInfo Gpu { get; set; }
    }
}
