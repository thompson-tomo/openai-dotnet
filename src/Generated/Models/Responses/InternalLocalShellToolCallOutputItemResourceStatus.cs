// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalLocalShellToolCallOutputItemResourceStatus : IEquatable<InternalLocalShellToolCallOutputItemResourceStatus>
    {
        private readonly string _value;
        private const string InProgressValue = "in_progress";
        private const string CompletedValue = "completed";
        private const string IncompleteValue = "incomplete";

        public InternalLocalShellToolCallOutputItemResourceStatus(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalLocalShellToolCallOutputItemResourceStatus InProgress { get; } = new InternalLocalShellToolCallOutputItemResourceStatus(InProgressValue);

        internal static InternalLocalShellToolCallOutputItemResourceStatus Completed { get; } = new InternalLocalShellToolCallOutputItemResourceStatus(CompletedValue);

        internal static InternalLocalShellToolCallOutputItemResourceStatus Incomplete { get; } = new InternalLocalShellToolCallOutputItemResourceStatus(IncompleteValue);

        public static bool operator ==(InternalLocalShellToolCallOutputItemResourceStatus left, InternalLocalShellToolCallOutputItemResourceStatus right) => left.Equals(right);

        public static bool operator !=(InternalLocalShellToolCallOutputItemResourceStatus left, InternalLocalShellToolCallOutputItemResourceStatus right) => !left.Equals(right);

        public static implicit operator InternalLocalShellToolCallOutputItemResourceStatus(string value) => new InternalLocalShellToolCallOutputItemResourceStatus(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalLocalShellToolCallOutputItemResourceStatus other && Equals(other);

        public bool Equals(InternalLocalShellToolCallOutputItemResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
