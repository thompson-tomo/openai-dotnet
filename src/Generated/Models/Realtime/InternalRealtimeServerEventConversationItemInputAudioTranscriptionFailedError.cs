// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError()
        {
        }

        internal InternalRealtimeServerEventConversationItemInputAudioTranscriptionFailedError(string kind, string code, string message, string @param, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            Code = code;
            Message = message;
            Param = @param;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Kind { get; }

        public string Code { get; }

        public string Message { get; }

        public string Param { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
