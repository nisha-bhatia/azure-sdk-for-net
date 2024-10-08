// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the storage account type to be used to store the image. This property is not updatable. </summary>
    public readonly partial struct EdgeZoneStorageAccountType : IEquatable<EdgeZoneStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeZoneStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeZoneStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLrsValue = "Standard_LRS";
        private const string StandardZrsValue = "Standard_ZRS";
        private const string StandardSsdLrsValue = "StandardSSD_LRS";
        private const string PremiumLrsValue = "Premium_LRS";

        /// <summary> Standard_LRS. </summary>
        public static EdgeZoneStorageAccountType StandardLrs { get; } = new EdgeZoneStorageAccountType(StandardLrsValue);
        /// <summary> Standard_ZRS. </summary>
        public static EdgeZoneStorageAccountType StandardZrs { get; } = new EdgeZoneStorageAccountType(StandardZrsValue);
        /// <summary> StandardSSD_LRS. </summary>
        public static EdgeZoneStorageAccountType StandardSsdLrs { get; } = new EdgeZoneStorageAccountType(StandardSsdLrsValue);
        /// <summary> Premium_LRS. </summary>
        public static EdgeZoneStorageAccountType PremiumLrs { get; } = new EdgeZoneStorageAccountType(PremiumLrsValue);
        /// <summary> Determines if two <see cref="EdgeZoneStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(EdgeZoneStorageAccountType left, EdgeZoneStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeZoneStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(EdgeZoneStorageAccountType left, EdgeZoneStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeZoneStorageAccountType"/>. </summary>
        public static implicit operator EdgeZoneStorageAccountType(string value) => new EdgeZoneStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeZoneStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeZoneStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
