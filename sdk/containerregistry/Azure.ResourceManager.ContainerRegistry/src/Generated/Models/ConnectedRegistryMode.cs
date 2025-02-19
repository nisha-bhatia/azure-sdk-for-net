// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The mode of the connected registry resource that indicates the permissions of the registry. </summary>
    public readonly partial struct ConnectedRegistryMode : IEquatable<ConnectedRegistryMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectedRegistryMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadWriteValue = "ReadWrite";
        private const string ReadOnlyValue = "ReadOnly";
        private const string RegistryValue = "Registry";
        private const string MirrorValue = "Mirror";

        /// <summary> ReadWrite. </summary>
        public static ConnectedRegistryMode ReadWrite { get; } = new ConnectedRegistryMode(ReadWriteValue);
        /// <summary> ReadOnly. </summary>
        public static ConnectedRegistryMode ReadOnly { get; } = new ConnectedRegistryMode(ReadOnlyValue);
        /// <summary> Registry. </summary>
        public static ConnectedRegistryMode Registry { get; } = new ConnectedRegistryMode(RegistryValue);
        /// <summary> Mirror. </summary>
        public static ConnectedRegistryMode Mirror { get; } = new ConnectedRegistryMode(MirrorValue);
        /// <summary> Determines if two <see cref="ConnectedRegistryMode"/> values are the same. </summary>
        public static bool operator ==(ConnectedRegistryMode left, ConnectedRegistryMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectedRegistryMode"/> values are not the same. </summary>
        public static bool operator !=(ConnectedRegistryMode left, ConnectedRegistryMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectedRegistryMode"/>. </summary>
        public static implicit operator ConnectedRegistryMode(string value) => new ConnectedRegistryMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectedRegistryMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectedRegistryMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
