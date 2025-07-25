// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal readonly partial struct InternalDotNetCombinedChunkingStrategyParamType : IEquatable<InternalDotNetCombinedChunkingStrategyParamType>
    {
        private readonly string _value;
        private const string AutoValue = "auto";
        private const string StaticValue = "static";
        private const string OtherValue = "other";

        public InternalDotNetCombinedChunkingStrategyParamType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalDotNetCombinedChunkingStrategyParamType Auto { get; } = new InternalDotNetCombinedChunkingStrategyParamType(AutoValue);

        internal static InternalDotNetCombinedChunkingStrategyParamType Static { get; } = new InternalDotNetCombinedChunkingStrategyParamType(StaticValue);

        internal static InternalDotNetCombinedChunkingStrategyParamType Other { get; } = new InternalDotNetCombinedChunkingStrategyParamType(OtherValue);

        public static bool operator ==(InternalDotNetCombinedChunkingStrategyParamType left, InternalDotNetCombinedChunkingStrategyParamType right) => left.Equals(right);

        public static bool operator !=(InternalDotNetCombinedChunkingStrategyParamType left, InternalDotNetCombinedChunkingStrategyParamType right) => !left.Equals(right);

        public static implicit operator InternalDotNetCombinedChunkingStrategyParamType(string value) => new InternalDotNetCombinedChunkingStrategyParamType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalDotNetCombinedChunkingStrategyParamType other && Equals(other);

        public bool Equals(InternalDotNetCombinedChunkingStrategyParamType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
