// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using OpenAI.Internal;

namespace OpenAI.Chat
{
    [Experimental("OPENAI001")]
    public partial class ChatWebSearchOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public ChatWebSearchOptions()
        {
        }

        internal ChatWebSearchOptions(InternalCreateChatCompletionRequestWebSearchOptionsUserLocation1 userLocation, InternalWebSearchContextSize? searchContextSize, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            UserLocation = userLocation;
            SearchContextSize = searchContextSize;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
