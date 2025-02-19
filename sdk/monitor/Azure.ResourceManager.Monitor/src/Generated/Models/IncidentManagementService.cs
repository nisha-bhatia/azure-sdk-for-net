// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The incident management service type. </summary>
    public readonly partial struct IncidentManagementService : IEquatable<IncidentManagementService>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IncidentManagementService"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IncidentManagementService(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IcmValue = "Icm";

        /// <summary> Icm. </summary>
        public static IncidentManagementService Icm { get; } = new IncidentManagementService(IcmValue);
        /// <summary> Determines if two <see cref="IncidentManagementService"/> values are the same. </summary>
        public static bool operator ==(IncidentManagementService left, IncidentManagementService right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IncidentManagementService"/> values are not the same. </summary>
        public static bool operator !=(IncidentManagementService left, IncidentManagementService right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IncidentManagementService"/>. </summary>
        public static implicit operator IncidentManagementService(string value) => new IncidentManagementService(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IncidentManagementService other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IncidentManagementService other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
