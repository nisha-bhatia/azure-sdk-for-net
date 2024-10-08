// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HciHealthState. </summary>
    public readonly partial struct HciHealthState : IEquatable<HciHealthState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciHealthState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciHealthState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SuccessValue = "Success";
        private const string FailureValue = "Failure";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string InProgressValue = "InProgress";

        /// <summary> Unknown. </summary>
        public static HciHealthState Unknown { get; } = new HciHealthState(UnknownValue);
        /// <summary> Success. </summary>
        public static HciHealthState Success { get; } = new HciHealthState(SuccessValue);
        /// <summary> Failure. </summary>
        public static HciHealthState Failure { get; } = new HciHealthState(FailureValue);
        /// <summary> Warning. </summary>
        public static HciHealthState Warning { get; } = new HciHealthState(WarningValue);
        /// <summary> Error. </summary>
        public static HciHealthState Error { get; } = new HciHealthState(ErrorValue);
        /// <summary> InProgress. </summary>
        public static HciHealthState InProgress { get; } = new HciHealthState(InProgressValue);
        /// <summary> Determines if two <see cref="HciHealthState"/> values are the same. </summary>
        public static bool operator ==(HciHealthState left, HciHealthState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciHealthState"/> values are not the same. </summary>
        public static bool operator !=(HciHealthState left, HciHealthState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HciHealthState"/>. </summary>
        public static implicit operator HciHealthState(string value) => new HciHealthState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciHealthState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciHealthState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
