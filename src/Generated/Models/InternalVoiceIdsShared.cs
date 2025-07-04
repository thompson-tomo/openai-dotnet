// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Internal
{
    internal readonly partial struct InternalVoiceIdsShared : IEquatable<InternalVoiceIdsShared>
    {
        private readonly string _value;
        private const string AlloyValue = "alloy";
        private const string AshValue = "ash";
        private const string BalladValue = "ballad";
        private const string CoralValue = "coral";
        private const string EchoValue = "echo";
        private const string FableValue = "fable";
        private const string OnyxValue = "onyx";
        private const string NovaValue = "nova";
        private const string SageValue = "sage";
        private const string ShimmerValue = "shimmer";
        private const string VerseValue = "verse";

        public InternalVoiceIdsShared(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalVoiceIdsShared Alloy { get; } = new InternalVoiceIdsShared(AlloyValue);

        internal static InternalVoiceIdsShared Ash { get; } = new InternalVoiceIdsShared(AshValue);

        internal static InternalVoiceIdsShared Ballad { get; } = new InternalVoiceIdsShared(BalladValue);

        internal static InternalVoiceIdsShared Coral { get; } = new InternalVoiceIdsShared(CoralValue);

        internal static InternalVoiceIdsShared Echo { get; } = new InternalVoiceIdsShared(EchoValue);

        internal static InternalVoiceIdsShared Fable { get; } = new InternalVoiceIdsShared(FableValue);

        internal static InternalVoiceIdsShared Onyx { get; } = new InternalVoiceIdsShared(OnyxValue);

        internal static InternalVoiceIdsShared Nova { get; } = new InternalVoiceIdsShared(NovaValue);

        internal static InternalVoiceIdsShared Sage { get; } = new InternalVoiceIdsShared(SageValue);

        internal static InternalVoiceIdsShared Shimmer { get; } = new InternalVoiceIdsShared(ShimmerValue);

        internal static InternalVoiceIdsShared Verse { get; } = new InternalVoiceIdsShared(VerseValue);

        public static bool operator ==(InternalVoiceIdsShared left, InternalVoiceIdsShared right) => left.Equals(right);

        public static bool operator !=(InternalVoiceIdsShared left, InternalVoiceIdsShared right) => !left.Equals(right);

        public static implicit operator InternalVoiceIdsShared(string value) => new InternalVoiceIdsShared(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalVoiceIdsShared other && Equals(other);

        public bool Equals(InternalVoiceIdsShared other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
