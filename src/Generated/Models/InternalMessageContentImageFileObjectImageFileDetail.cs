// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalMessageContentImageFileObjectImageFileDetail : IEquatable<InternalMessageContentImageFileObjectImageFileDetail>
    {
        private readonly string _value;
        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        public InternalMessageContentImageFileObjectImageFileDetail(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalMessageContentImageFileObjectImageFileDetail Auto { get; } = new InternalMessageContentImageFileObjectImageFileDetail(AutoValue);

        internal static InternalMessageContentImageFileObjectImageFileDetail Low { get; } = new InternalMessageContentImageFileObjectImageFileDetail(LowValue);

        internal static InternalMessageContentImageFileObjectImageFileDetail High { get; } = new InternalMessageContentImageFileObjectImageFileDetail(HighValue);

        public static bool operator ==(InternalMessageContentImageFileObjectImageFileDetail left, InternalMessageContentImageFileObjectImageFileDetail right) => left.Equals(right);

        public static bool operator !=(InternalMessageContentImageFileObjectImageFileDetail left, InternalMessageContentImageFileObjectImageFileDetail right) => !left.Equals(right);

        public static implicit operator InternalMessageContentImageFileObjectImageFileDetail(string value) => new InternalMessageContentImageFileObjectImageFileDetail(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageContentImageFileObjectImageFileDetail other && Equals(other);

        public bool Equals(InternalMessageContentImageFileObjectImageFileDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
