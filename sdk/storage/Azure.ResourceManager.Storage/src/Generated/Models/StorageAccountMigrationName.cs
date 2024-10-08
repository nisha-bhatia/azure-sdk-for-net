// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StorageAccountMigrationName. </summary>
    public readonly partial struct StorageAccountMigrationName : IEquatable<StorageAccountMigrationName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageAccountMigrationName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageAccountMigrationName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static StorageAccountMigrationName Default { get; } = new StorageAccountMigrationName(DefaultValue);
        /// <summary> Determines if two <see cref="StorageAccountMigrationName"/> values are the same. </summary>
        public static bool operator ==(StorageAccountMigrationName left, StorageAccountMigrationName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageAccountMigrationName"/> values are not the same. </summary>
        public static bool operator !=(StorageAccountMigrationName left, StorageAccountMigrationName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageAccountMigrationName"/>. </summary>
        public static implicit operator StorageAccountMigrationName(string value) => new StorageAccountMigrationName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageAccountMigrationName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageAccountMigrationName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
