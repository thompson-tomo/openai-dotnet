// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Images
{
    public readonly partial struct GeneratedImageSize : IEquatable<GeneratedImageSize>
    {
        private readonly string _value;
        private const string AutoValue = "auto";
        private const string _1024x1024Value = "1024x1024";
        private const string _1536x1024Value = "1536x1024";
        private const string _1024x1536Value = "1024x1536";
        private const string _256x256Value = "256x256";
        private const string _512x512Value = "512x512";
        private const string _1792x1024Value = "1792x1024";
        private const string _1024x1792Value = "1024x1792";

        [Experimental("OPENAI001")]
        public static GeneratedImageSize Auto { get; } = new GeneratedImageSize(AutoValue);

        public static bool operator ==(GeneratedImageSize left, GeneratedImageSize right) => left.Equals(right);

        public static bool operator !=(GeneratedImageSize left, GeneratedImageSize right) => !left.Equals(right);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeneratedImageSize other && Equals(other);

        public bool Equals(GeneratedImageSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
