// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Type of link. </summary>
    public readonly partial struct ResourceHealthEventLinkTypeValue : IEquatable<ResourceHealthEventLinkTypeValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventLinkTypeValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthEventLinkTypeValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ButtonValue = "Button";
        private const string HyperlinkValue = "Hyperlink";

        /// <summary> Button. </summary>
        public static ResourceHealthEventLinkTypeValue Button { get; } = new ResourceHealthEventLinkTypeValue(ButtonValue);
        /// <summary> Hyperlink. </summary>
        public static ResourceHealthEventLinkTypeValue Hyperlink { get; } = new ResourceHealthEventLinkTypeValue(HyperlinkValue);
        /// <summary> Determines if two <see cref="ResourceHealthEventLinkTypeValue"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthEventLinkTypeValue left, ResourceHealthEventLinkTypeValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthEventLinkTypeValue"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthEventLinkTypeValue left, ResourceHealthEventLinkTypeValue right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceHealthEventLinkTypeValue"/>. </summary>
        public static implicit operator ResourceHealthEventLinkTypeValue(string value) => new ResourceHealthEventLinkTypeValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthEventLinkTypeValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthEventLinkTypeValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
