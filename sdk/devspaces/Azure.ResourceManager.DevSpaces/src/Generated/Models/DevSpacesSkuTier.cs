// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The tier of the SKU for Azure Dev Spaces Controller. </summary>
    public readonly partial struct DevSpacesSkuTier : IEquatable<DevSpacesSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevSpacesSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevSpacesSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";

        /// <summary> Standard. </summary>
        public static DevSpacesSkuTier Standard { get; } = new DevSpacesSkuTier(StandardValue);
        /// <summary> Determines if two <see cref="DevSpacesSkuTier"/> values are the same. </summary>
        public static bool operator ==(DevSpacesSkuTier left, DevSpacesSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevSpacesSkuTier"/> values are not the same. </summary>
        public static bool operator !=(DevSpacesSkuTier left, DevSpacesSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevSpacesSkuTier"/>. </summary>
        public static implicit operator DevSpacesSkuTier(string value) => new DevSpacesSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevSpacesSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevSpacesSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
