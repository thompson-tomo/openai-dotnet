// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal abstract partial class InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(RunStepToolCallKind kind)
        {
            Kind = kind;
        }

        internal InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(RunStepToolCallKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal RunStepToolCallKind Kind { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
