// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Enum mapping of SMO LoginType. </summary>
    public readonly partial struct LoginType : IEquatable<LoginType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LoginType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoginType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsUserValue = "WindowsUser";
        private const string WindowsGroupValue = "WindowsGroup";
        private const string SqlLoginValue = "SqlLogin";
        private const string CertificateValue = "Certificate";
        private const string AsymmetricKeyValue = "AsymmetricKey";
        private const string ExternalUserValue = "ExternalUser";
        private const string ExternalGroupValue = "ExternalGroup";

        /// <summary> WindowsUser. </summary>
        public static LoginType WindowsUser { get; } = new LoginType(WindowsUserValue);
        /// <summary> WindowsGroup. </summary>
        public static LoginType WindowsGroup { get; } = new LoginType(WindowsGroupValue);
        /// <summary> SqlLogin. </summary>
        public static LoginType SqlLogin { get; } = new LoginType(SqlLoginValue);
        /// <summary> Certificate. </summary>
        public static LoginType Certificate { get; } = new LoginType(CertificateValue);
        /// <summary> AsymmetricKey. </summary>
        public static LoginType AsymmetricKey { get; } = new LoginType(AsymmetricKeyValue);
        /// <summary> ExternalUser. </summary>
        public static LoginType ExternalUser { get; } = new LoginType(ExternalUserValue);
        /// <summary> ExternalGroup. </summary>
        public static LoginType ExternalGroup { get; } = new LoginType(ExternalGroupValue);
        /// <summary> Determines if two <see cref="LoginType"/> values are the same. </summary>
        public static bool operator ==(LoginType left, LoginType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoginType"/> values are not the same. </summary>
        public static bool operator !=(LoginType left, LoginType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LoginType"/>. </summary>
        public static implicit operator LoginType(string value) => new LoginType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoginType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoginType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
