// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MixedReality.Models
{
    /// <summary> reason of name unavailable. </summary>
    public readonly partial struct MixedRealityNameUnavailableReason : IEquatable<MixedRealityNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MixedRealityNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MixedRealityNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static MixedRealityNameUnavailableReason Invalid { get; } = new MixedRealityNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static MixedRealityNameUnavailableReason AlreadyExists { get; } = new MixedRealityNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="MixedRealityNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(MixedRealityNameUnavailableReason left, MixedRealityNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MixedRealityNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(MixedRealityNameUnavailableReason left, MixedRealityNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MixedRealityNameUnavailableReason"/>. </summary>
        public static implicit operator MixedRealityNameUnavailableReason(string value) => new MixedRealityNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MixedRealityNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MixedRealityNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
