// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> The unit used by the width, height, and polygon properties. For images, the unit is "pixel". For PDF, the unit is "inch". </summary>
    public readonly partial struct LengthUnit : IEquatable<LengthUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LengthUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LengthUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PixelValue = "pixel";
        private const string InchValue = "inch";

        /// <summary> Length unit for image files. </summary>
        public static LengthUnit Pixel { get; } = new LengthUnit(PixelValue);
        /// <summary> Length unit for PDF files. </summary>
        public static LengthUnit Inch { get; } = new LengthUnit(InchValue);
        /// <summary> Determines if two <see cref="LengthUnit"/> values are the same. </summary>
        public static bool operator ==(LengthUnit left, LengthUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LengthUnit"/> values are not the same. </summary>
        public static bool operator !=(LengthUnit left, LengthUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LengthUnit"/>. </summary>
        public static implicit operator LengthUnit(string value) => new LengthUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LengthUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LengthUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
