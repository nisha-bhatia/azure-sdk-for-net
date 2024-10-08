// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Policy for how the initial upload sync session is performed. </summary>
    public readonly partial struct InitialUploadPolicy : IEquatable<InitialUploadPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InitialUploadPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InitialUploadPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerAuthoritativeValue = "ServerAuthoritative";
        private const string MergeValue = "Merge";

        /// <summary> ServerAuthoritative. </summary>
        public static InitialUploadPolicy ServerAuthoritative { get; } = new InitialUploadPolicy(ServerAuthoritativeValue);
        /// <summary> Merge. </summary>
        public static InitialUploadPolicy Merge { get; } = new InitialUploadPolicy(MergeValue);
        /// <summary> Determines if two <see cref="InitialUploadPolicy"/> values are the same. </summary>
        public static bool operator ==(InitialUploadPolicy left, InitialUploadPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InitialUploadPolicy"/> values are not the same. </summary>
        public static bool operator !=(InitialUploadPolicy left, InitialUploadPolicy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InitialUploadPolicy"/>. </summary>
        public static implicit operator InitialUploadPolicy(string value) => new InitialUploadPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InitialUploadPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InitialUploadPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
