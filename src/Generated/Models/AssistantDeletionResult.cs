// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class AssistantDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal AssistantDeletionResult(bool deleted, string assistantId)
        {
            Deleted = deleted;
            AssistantId = assistantId;
        }

        internal AssistantDeletionResult(bool deleted, string assistantId, string @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            AssistantId = assistantId;
            Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
