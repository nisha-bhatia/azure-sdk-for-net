// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Router Job Worker Selector Label Operator. </summary>
    public readonly partial struct AcsRouterLabelOperator : IEquatable<AcsRouterLabelOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcsRouterLabelOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcsRouterLabelOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualValue = "Equal";
        private const string NotEqualValue = "NotEqual";
        private const string GreaterValue = "Greater";
        private const string LessValue = "Less";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string LessThanOrEqualValue = "LessThanOrEqual";

        /// <summary> =. </summary>
        public static AcsRouterLabelOperator Equal { get; } = new AcsRouterLabelOperator(EqualValue);
        /// <summary> !=. </summary>
        public static AcsRouterLabelOperator NotEqual { get; } = new AcsRouterLabelOperator(NotEqualValue);
        /// <summary> &gt;. </summary>
        public static AcsRouterLabelOperator Greater { get; } = new AcsRouterLabelOperator(GreaterValue);
        /// <summary> &lt;. </summary>
        public static AcsRouterLabelOperator Less { get; } = new AcsRouterLabelOperator(LessValue);
        /// <summary> &gt;=. </summary>
        public static AcsRouterLabelOperator GreaterThanOrEqual { get; } = new AcsRouterLabelOperator(GreaterThanOrEqualValue);
        /// <summary> &lt;=. </summary>
        public static AcsRouterLabelOperator LessThanOrEqual { get; } = new AcsRouterLabelOperator(LessThanOrEqualValue);
        /// <summary> Determines if two <see cref="AcsRouterLabelOperator"/> values are the same. </summary>
        public static bool operator ==(AcsRouterLabelOperator left, AcsRouterLabelOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcsRouterLabelOperator"/> values are not the same. </summary>
        public static bool operator !=(AcsRouterLabelOperator left, AcsRouterLabelOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AcsRouterLabelOperator"/>. </summary>
        public static implicit operator AcsRouterLabelOperator(string value) => new AcsRouterLabelOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcsRouterLabelOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcsRouterLabelOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
