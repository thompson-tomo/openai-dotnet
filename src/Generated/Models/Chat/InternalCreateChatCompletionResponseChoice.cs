// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoice
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalCreateChatCompletionResponseChoice(ChatFinishReason finishReason, int index, InternalChatCompletionResponseMessage message, InternalCreateChatCompletionResponseChoiceLogprobs logprobs)
        {
            FinishReason = finishReason;
            Index = index;
            Message = message;
            Logprobs = logprobs;
        }

        internal InternalCreateChatCompletionResponseChoice(ChatFinishReason finishReason, int index, InternalChatCompletionResponseMessage message, InternalCreateChatCompletionResponseChoiceLogprobs logprobs, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FinishReason = finishReason;
            Index = index;
            Message = message;
            Logprobs = logprobs;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public ChatFinishReason FinishReason { get; }

        public int Index { get; }

        internal InternalChatCompletionResponseMessage Message { get; }

        internal InternalCreateChatCompletionResponseChoiceLogprobs Logprobs { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
