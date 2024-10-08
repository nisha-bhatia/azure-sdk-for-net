// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The template type. </summary>
    public readonly partial struct TemplateType : IEquatable<TemplateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TemplateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TemplateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ArmTemplateValue = "ArmTemplate";

        /// <summary> Unknown. </summary>
        public static TemplateType Unknown { get; } = new TemplateType(UnknownValue);
        /// <summary> ArmTemplate. </summary>
        public static TemplateType ArmTemplate { get; } = new TemplateType(ArmTemplateValue);
        /// <summary> Determines if two <see cref="TemplateType"/> values are the same. </summary>
        public static bool operator ==(TemplateType left, TemplateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TemplateType"/> values are not the same. </summary>
        public static bool operator !=(TemplateType left, TemplateType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TemplateType"/>. </summary>
        public static implicit operator TemplateType(string value) => new TemplateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TemplateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TemplateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
