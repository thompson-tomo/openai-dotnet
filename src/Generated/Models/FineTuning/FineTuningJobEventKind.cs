// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using OpenAI;

namespace OpenAI.FineTuning
{
    [Experimental("OPENAI001")]
    public readonly partial struct FineTuningJobEventKind : IEquatable<FineTuningJobEventKind>
    {
        private readonly string _value;
        private const string MessageValue = "message";
        private const string MetricsValue = "metrics";

        public FineTuningJobEventKind(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static FineTuningJobEventKind Message { get; } = new FineTuningJobEventKind(MessageValue);

        public static FineTuningJobEventKind Metrics { get; } = new FineTuningJobEventKind(MetricsValue);

        public static bool operator ==(FineTuningJobEventKind left, FineTuningJobEventKind right) => left.Equals(right);

        public static bool operator !=(FineTuningJobEventKind left, FineTuningJobEventKind right) => !left.Equals(right);

        public static implicit operator FineTuningJobEventKind(string value) => new FineTuningJobEventKind(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FineTuningJobEventKind other && Equals(other);

        public bool Equals(FineTuningJobEventKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
