// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Direction that specifies whether the access rules is inbound/outbound. </summary>
    public readonly partial struct NetworkSecurityPerimeterAccessRuleDirection : IEquatable<NetworkSecurityPerimeterAccessRuleDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterAccessRuleDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkSecurityPerimeterAccessRuleDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static NetworkSecurityPerimeterAccessRuleDirection Inbound { get; } = new NetworkSecurityPerimeterAccessRuleDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static NetworkSecurityPerimeterAccessRuleDirection Outbound { get; } = new NetworkSecurityPerimeterAccessRuleDirection(OutboundValue);
        /// <summary> Determines if two <see cref="NetworkSecurityPerimeterAccessRuleDirection"/> values are the same. </summary>
        public static bool operator ==(NetworkSecurityPerimeterAccessRuleDirection left, NetworkSecurityPerimeterAccessRuleDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkSecurityPerimeterAccessRuleDirection"/> values are not the same. </summary>
        public static bool operator !=(NetworkSecurityPerimeterAccessRuleDirection left, NetworkSecurityPerimeterAccessRuleDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkSecurityPerimeterAccessRuleDirection"/>. </summary>
        public static implicit operator NetworkSecurityPerimeterAccessRuleDirection(string value) => new NetworkSecurityPerimeterAccessRuleDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkSecurityPerimeterAccessRuleDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkSecurityPerimeterAccessRuleDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
