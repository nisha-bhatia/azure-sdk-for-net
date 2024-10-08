// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The sku name. </summary>
    public readonly partial struct LogicSkuName : IEquatable<LogicSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string FreeValue = "Free";
        private const string SharedValue = "Shared";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> NotSpecified. </summary>
        public static LogicSkuName NotSpecified { get; } = new LogicSkuName(NotSpecifiedValue);
        /// <summary> Free. </summary>
        public static LogicSkuName Free { get; } = new LogicSkuName(FreeValue);
        /// <summary> Shared. </summary>
        public static LogicSkuName Shared { get; } = new LogicSkuName(SharedValue);
        /// <summary> Basic. </summary>
        public static LogicSkuName Basic { get; } = new LogicSkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static LogicSkuName Standard { get; } = new LogicSkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static LogicSkuName Premium { get; } = new LogicSkuName(PremiumValue);
        /// <summary> Determines if two <see cref="LogicSkuName"/> values are the same. </summary>
        public static bool operator ==(LogicSkuName left, LogicSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicSkuName"/> values are not the same. </summary>
        public static bool operator !=(LogicSkuName left, LogicSkuName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LogicSkuName"/>. </summary>
        public static implicit operator LogicSkuName(string value) => new LogicSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
