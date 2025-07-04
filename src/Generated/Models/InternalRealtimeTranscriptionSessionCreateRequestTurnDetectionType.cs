// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Realtime
{
    internal readonly partial struct InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType : IEquatable<InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType>
    {
        private readonly string _value;
        private const string ServerVadValue = "server_vad";
        private const string SemanticVadValue = "semantic_vad";

        public InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType ServerVad { get; } = new InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType(ServerVadValue);

        internal static InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType SemanticVad { get; } = new InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType(SemanticVadValue);

        public static bool operator ==(InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType left, InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType right) => left.Equals(right);

        public static bool operator !=(InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType left, InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType right) => !left.Equals(right);

        public static implicit operator InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType(string value) => new InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType other && Equals(other);

        public bool Equals(InternalRealtimeTranscriptionSessionCreateRequestTurnDetectionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
