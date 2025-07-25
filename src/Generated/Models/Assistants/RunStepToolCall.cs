// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Assistants
{
    [Experimental("OPENAI001")]
    public partial class RunStepToolCall
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected RunStepToolCall(RunStepToolCallKind kind, string id)
        {
            Kind = kind;
            Id = id;
        }

        internal RunStepToolCall(RunStepToolCallKind kind, string id, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            Id = id;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public RunStepToolCallKind Kind { get; }

        public string Id { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
