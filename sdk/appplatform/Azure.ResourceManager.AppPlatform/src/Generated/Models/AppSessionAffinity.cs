// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Type of the affinity, set this to Cookie to enable session affinity. </summary>
    public readonly partial struct AppSessionAffinity : IEquatable<AppSessionAffinity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppSessionAffinity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppSessionAffinity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CookieValue = "Cookie";
        private const string NoneValue = "None";

        /// <summary> Cookie. </summary>
        public static AppSessionAffinity Cookie { get; } = new AppSessionAffinity(CookieValue);
        /// <summary> None. </summary>
        public static AppSessionAffinity None { get; } = new AppSessionAffinity(NoneValue);
        /// <summary> Determines if two <see cref="AppSessionAffinity"/> values are the same. </summary>
        public static bool operator ==(AppSessionAffinity left, AppSessionAffinity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppSessionAffinity"/> values are not the same. </summary>
        public static bool operator !=(AppSessionAffinity left, AppSessionAffinity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppSessionAffinity"/>. </summary>
        public static implicit operator AppSessionAffinity(string value) => new AppSessionAffinity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppSessionAffinity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppSessionAffinity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
