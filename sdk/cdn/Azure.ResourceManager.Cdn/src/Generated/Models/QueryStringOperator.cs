// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct QueryStringOperator : IEquatable<QueryStringOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryStringOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryStringOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string EqualValue = "Equal";
        private const string ContainsValue = "Contains";
        private const string BeginsWithValue = "BeginsWith";
        private const string EndsWithValue = "EndsWith";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string RegExValue = "RegEx";

        /// <summary> Any. </summary>
        public static QueryStringOperator Any { get; } = new QueryStringOperator(AnyValue);
        /// <summary> Equal. </summary>
        public static QueryStringOperator Equal { get; } = new QueryStringOperator(EqualValue);
        /// <summary> Contains. </summary>
        public static QueryStringOperator Contains { get; } = new QueryStringOperator(ContainsValue);
        /// <summary> BeginsWith. </summary>
        public static QueryStringOperator BeginsWith { get; } = new QueryStringOperator(BeginsWithValue);
        /// <summary> EndsWith. </summary>
        public static QueryStringOperator EndsWith { get; } = new QueryStringOperator(EndsWithValue);
        /// <summary> LessThan. </summary>
        public static QueryStringOperator LessThan { get; } = new QueryStringOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static QueryStringOperator LessThanOrEqual { get; } = new QueryStringOperator(LessThanOrEqualValue);
        /// <summary> GreaterThan. </summary>
        public static QueryStringOperator GreaterThan { get; } = new QueryStringOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static QueryStringOperator GreaterThanOrEqual { get; } = new QueryStringOperator(GreaterThanOrEqualValue);
        /// <summary> RegEx. </summary>
        public static QueryStringOperator RegEx { get; } = new QueryStringOperator(RegExValue);
        /// <summary> Determines if two <see cref="QueryStringOperator"/> values are the same. </summary>
        public static bool operator ==(QueryStringOperator left, QueryStringOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryStringOperator"/> values are not the same. </summary>
        public static bool operator !=(QueryStringOperator left, QueryStringOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="QueryStringOperator"/>. </summary>
        public static implicit operator QueryStringOperator(string value) => new QueryStringOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryStringOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryStringOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
